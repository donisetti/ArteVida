﻿using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web.Mvc;
using ArteVida.Dominio.Contexto;
using ArteVida.Dominio.Repositorio;
using ArteVida.Dominio.Entidades;
using AutoMapper;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

using ArteVida.GestorWeb.ViewModels;
using Microsoft.Ajax.Utilities;

namespace ArteVida.GestorWeb.Controllers
{
    public class AtletaController : Controller
    {

        private DbContexto _contexto;
        private RepositorioAtleta _repositorio;

        private int _AtletaId;

        public AtletaController()
        {
            _contexto = new DbContexto();
            _repositorio = new RepositorioAtleta(_contexto);


            // ViewData["Funcionarios"] = _repositorioFuncionario.ObterTodos().Select(c => new { Id = c.PessoaId, Nome = c.Nome }).OrderBy(x=>x.Nome);           

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Consulta()
        {

            var model = new JanelaViewModel
            {
                Titulo = "Cadastro de Atletas",
                Relatorio = "ListagemAtletas.trdx",
                Tela = "_GridAtletas"
            };
            return View("_ConsultaBase", model);
        }

        //FichaAtleta

        public ActionResult FichaAtleta()
        {
            var model = new JanelaViewModel
            {
                Titulo = "Ficha Atleta",
                Relatorio = "ListagemAtletas.trdx",
                Tela = "_FichaAtletas"
            };
            return View("_ConsultaBase", model);
        }

        public ActionResult Ler([DataSourceRequest] DataSourceRequest request)
        {
            return Json(PegarAtletas().ToDataSourceResult(request));
        }





        private IQueryable<AtletaViewModel> PegarAtletas(string tipo = "Todos")
        {
            if (tipo != "Todos")
            {

                var dados = _repositorio.ObterTodos().ProjectTo<AtletaViewModel>();


                return dados;
            }
            else
            {

                var dados = _repositorio.ObterTodos().ProjectTo<AtletaViewModel>();


                return dados;

            }
        }



        public ActionResult Incluir([DataSourceRequest] DataSourceRequest request, AtletaViewModel item, string atletaId)
        {
            if (atletaId.IsNullOrWhiteSpace())
                return IncluirAtleta(request, item);
            else
            {
                _AtletaId = int.Parse(atletaId);

                item.PessoaId = _AtletaId;
                AlterarAtleta(item);
                return null;
            }
            
        }

        private void AlterarAtleta(AtletaViewModel item)
        {
            if (ModelState.IsValid)
            {
                try
                {                   
                    var dados = MapearViewModel(item);
                    dados = _repositorio.Atualizar(dados);
                    _contexto.Commit();
                }
                catch (Exception erro)
                {
                    ModelState.AddModelError("", erro.Message);
                    _contexto.Rollback();
                }
            }
        }


        public ActionResult Atualizar([DataSourceRequest] DataSourceRequest request, AtletaViewModel item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var dados = MapearViewModel(item);
                    dados = _repositorio.Atualizar(dados);
                    _contexto.Commit();
                    item.PessoaId = dados.PessoaId;
                }
                catch (Exception erro)
                {

                    ModelState.AddModelError("", erro.Message);
                    _contexto.Rollback();

                }

            }
            else
            {
                var erros = this.ModelState.Values.SelectMany(m => m.Errors);

            }
            return Json(ModelState.ToDataSourceResult());

        }

        public ActionResult Excluir([DataSourceRequest] DataSourceRequest request, AtletaViewModel item)
        {
            try
            {
                // deve excluir Irmão vinculados

                var irmaos = _contexto.Irmoes.Where(i => i.PessoaId == item.PessoaId);

                foreach (Irmao irmao in irmaos)
                {
                    _contexto.Irmoes.Remove(irmao);
                }

                // Remove Atleta
                _contexto.Atletas.Remove(_contexto.Atletas.Find(item.PessoaId));
                _contexto.SaveChanges();
                ModelState.IsValidField("true");
            }
            catch (Exception erro)
            {
                ModelState.IsValidField("false");
                ModelState.AddModelError("", erro.Message);
                _contexto.Rollback();
            }
            return Json(ModelState.ToDataSourceResult());

        }


        [HttpPost]
        public ActionResult InserirAtleta([DataSourceRequest] DataSourceRequest request, AtletaViewModel item)
        {
            //AtletaViewModel itemNovo = new AtletaViewModel();

            AtletaViewModel itemNovo = Mapper.Map<AtletaViewModel>(item);

            // campos obrigatório
            itemNovo.Nome = item.Nome;

            // demais campos


            ContentResult _retorno;
            try
            {
                var novo = IncluirAtleta(request, itemNovo);
                _retorno = new ContentResult { Content = itemNovo.PessoaId.ToString() };
            }
            catch (Exception ex)
            {
                _retorno = new ContentResult { Content = "ERRO: " + ex.Message };
            }

            return _retorno;
        }

        private ActionResult IncluirAtleta(DataSourceRequest request, AtletaViewModel item)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var dados = MapearViewModel(item);

                    _repositorio.Inserir(dados);
                    _contexto.SaveChanges();
                    item.PessoaId = dados.PessoaId;

                }
                catch (Exception erro)
                {
                    ModelState.AddModelError("", erro.Message);
                    var erros = this.ModelState.Values.SelectMany(m => m.Errors);
                    _contexto.Rollback();
                    return Json(ModelState.ToDataSourceResult());
                }
            }
            else
            {
                var erros = this.ModelState.Values.SelectMany(m => m.Errors);

            }

            return Json(new[] { item }.ToDataSourceResult(request, ModelState));
        }

        private Atleta MapearViewModel(AtletaViewModel item)
        {
            Pessoa p = new Pessoa();
            Atleta dados = new Atleta();

            if (item.PessoaId > 0)
            {
                dados = _contexto.Atletas.Find(item.PessoaId);
            }

            dados.Nome = item.Nome;
            dados.DataNascimento = item.DataNascimento;
            dados.DataCadastro = item.DataCadastro;

            dados.Cpf = item.Cpf;

            dados.Pai = item.Pai;
            dados.Mae = item.Mae;

            dados.Escola = item.Escola;

            dados.Endereco = item.Endereco;
            dados.Bairro = item.Bairro;
            dados.Cidade = item.Cidade;
            dados.Estado = item.Estado;

            dados.Modalidade = item.Modalidade;
            dados.Telefone = item.Telefone;
            dados.TelefonePai = item.TelefonePai;
            dados.TelefoneMae = item.TelefoneMae;



            return dados;
        }
    }
}