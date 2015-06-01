using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArteVida.Dominio.Contexto;
using ArteVida.Dominio.Entidades;
using ArteVida.Dominio.Repositorio;
using ArteVida.GestorWeb.ViewModels;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace ArteVida.GestorWeb.Controllers.Cadastros
{
    public class InstrutorController : Controller
    {
        private DbContexto _contexto;
        private RepositorioInstrutor _repositorio;

        public InstrutorController()
        {
            _contexto = new DbContexto();
            _repositorio = new RepositorioInstrutor(_contexto);
        }

        // GET: Instrutor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Consulta()
        {

            var model = new JanelaViewModel { Titulo = "Cadastro de Instrutor", Relatorio = "ListagemInstrutores.trdx", Tela = "_GridInstrutor" };
            return View("_ConsultaBase", model);
        }


        public ActionResult Ler([DataSourceRequest] DataSourceRequest request)
        {
            return Json(PegarInstrutores().ToDataSourceResult(request));
        }





        private IQueryable<InstrutorViewModel> PegarInstrutores(string tipo = "Todos")
        {
            if (tipo != "Todos")
            {

                var dados = _repositorio.ObterTodos().Project().To<InstrutorViewModel>();


                return dados;
            }
            else
            {

                var dados = _repositorio.ObterTodos().Project().To<InstrutorViewModel>();


                return dados;

            }
        }



        public ActionResult Incluir([DataSourceRequest] DataSourceRequest request, InstrutorViewModel item)
        {


            if (ModelState.IsValid)
            {

                try
                {
                    Instrutor dados = Mapper.Map<Instrutor>(item);
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


        public ActionResult Atualizar([DataSourceRequest] DataSourceRequest request, InstrutorViewModel item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    Instrutor dados = Mapper.Map<Instrutor>(item);
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

        public ActionResult Excluir([DataSourceRequest] DataSourceRequest request, InstrutorViewModel item)
        {
            try
            {
                _contexto.Instrutores.Remove(_contexto.Instrutores.Find(item.PessoaId));
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