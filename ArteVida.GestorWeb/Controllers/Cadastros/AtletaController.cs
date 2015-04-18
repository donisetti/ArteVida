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
    public class AtletaController : Controller
    {

        private DbContexto _contexto;
        private RepositorioAtleta _repositorio;



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

            var model = new JanelaViewModel { Titulo = "Cadastro de Atletas", Relatorio = "ListagemAtletas.trdx", Tela = "_GridAtletas" };
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

                var dados = _repositorio.ObterTodos().Project().To<AtletaViewModel>();


                return dados;
            }
            else
            {

                var dados = _repositorio.ObterTodos().Project().To<AtletaViewModel>();


                return dados;

            }
        }



        public ActionResult Incluir([DataSourceRequest] DataSourceRequest request, AtletaViewModel item)
        {


            if (ModelState.IsValid)
            {

                try
                {
                    Atleta dados = Mapper.Map<Atleta>(item);
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


        public ActionResult Atualizar([DataSourceRequest] DataSourceRequest request, AtletaViewModel item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    Atleta dados = Mapper.Map<Atleta>(item);
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

        public ActionResult Excluir([DataSourceRequest] DataSourceRequest request, AtletaViewModel item)
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