using System;
using System.Linq;
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

namespace ArteVida.GestorWeb.Controllers
{
    public class PessoaController : Controller
    {

        private DbContexto _contexto;
        private RepositorioPessoa _repositorio;



        public PessoaController()
        {
            _contexto = new DbContexto();
            _repositorio = new RepositorioPessoa(_contexto);


            // ViewData["Funcionarios"] = _repositorioFuncionario.ObterTodos().Select(c => new { Id = c.PessoaId, Nome = c.Nome }).OrderBy(x=>x.Nome);           

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Consulta()
        {
         
            var model = new JanelaViewModel { Titulo = "Cadastro de Pessoas", Relatorio = "ListagemPessoas.trdx", Tela = "_GridPessoas" };
            return View("_ConsultaBase", model);
        }



        public ActionResult Ler([DataSourceRequest] DataSourceRequest request)
        {
            return Json(PegarPessoas().ToDataSourceResult(request));
        }





        private IQueryable<PessoaViewModel> PegarPessoas(string tipo = "Todos")
        {
            if (tipo != "Todos")
            {

                var dados = _repositorio.ObterTodos().Project().To<PessoaViewModel>();


                return dados;
            }
            else
            {

                var dados = _repositorio.ObterTodos().Project().To<PessoaViewModel>();


                return dados;

            }
        }



        public ActionResult Incluir([DataSourceRequest] DataSourceRequest request, PessoaViewModel item)
        {


            if (ModelState.IsValid)
            {

                try
                {
                    Pessoa dados = Mapper.Map<Pessoa>(item);
                    _repositorio.Inserir(dados);
                    _contexto.SaveChanges();
                    item.PessoaId = dados.PessoaId;
                }
                catch (Exception erro)
                {

                    if (erro.InnerException.InnerException.Message.Contains("IdxNome"))
                    {
                        ModelState.AddModelError("", "O nome já foi incluído.");
                    }

                    _contexto.Rollback();
                    return Json(ModelState.ToDataSourceResult());

                }



            }

            return Json(new[] { item }.ToDataSourceResult(request));
        }


        public ActionResult Atualizar([DataSourceRequest] DataSourceRequest request, PessoaViewModel item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    Pessoa dados = Mapper.Map<Pessoa>(item);
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
            return Json(ModelState.ToDataSourceResult());

        }

        public ActionResult Excluir([DataSourceRequest] DataSourceRequest request, PessoaViewModel item)
        {
            try
            {
                _contexto.TabelasAuxiliares.Remove(_contexto.TabelasAuxiliares.Find(item.PessoaId));
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


    }
}