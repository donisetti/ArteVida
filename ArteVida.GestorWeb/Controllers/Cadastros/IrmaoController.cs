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
    public class IrmaoController : Controller
    {

        private DbContexto _contexto;
        private RepositorioIrmao _repositorio;
        private RepositorioAtleta _repositorioAtleta;

        private int _AtletaId;

        public IrmaoController()
        {
            _contexto = new DbContexto();
            _repositorio = new RepositorioIrmao(_contexto);


            // ViewData["Funcionarios"] = _repositorioFuncionario.ObterTodos().Select(c => new { Id = c.PessoaId, Nome = c.Nome }).OrderBy(x=>x.Nome);           
         
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Consulta()
        {

            var model = new JanelaViewModel { Titulo = "Cadastro de Irmaos", Relatorio = "ListagemIrmaos.trdx", Tela = "_GridIrmaos" };
            return View("_ConsultaBase", model);
        }

        //public ActionResult Ler([DataSourceRequest] DataSourceRequest request)
        //{
        //    _AtletaId = 1;
        //    //_AtletaId = int.Parse(id);


        //    return Json(PegarIrmaos().ToDataSourceResult(request));
        //}

        public ActionResult Ler([DataSourceRequest] DataSourceRequest request, int id)
        {
            _AtletaId = id;
            //_AtletaId = int.Parse(id);


            return Json(PegarIrmaos().ToDataSourceResult(request));
        }





        private IQueryable<IrmaoViewModel> PegarIrmaos()
        {

            var dados = _repositorio.ObterTodos().Where(x => x.Atleta.PessoaId == _AtletaId).Project().To<IrmaoViewModel>();

                return dados;

        }



        public ActionResult Incluir([DataSourceRequest] DataSourceRequest request, IrmaoViewModel item)
        {


            if (ModelState.IsValid)
            {

                try
                {
                    Irmao dados = Mapper.Map<Irmao>(item);
                    _repositorio.Inserir(dados);
                    _contexto.SaveChanges();
                    item.IrmaoId = dados.IrmaoId;
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


        public ActionResult Atualizar([DataSourceRequest] DataSourceRequest request, IrmaoViewModel item)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    Irmao dados = Mapper.Map<Irmao>(item);
                    dados = _repositorio.Atualizar(dados);
                    _contexto.Commit();
                    item.IrmaoId = dados.IrmaoId;
                }
                catch (Exception erro)
                {

                    ModelState.AddModelError("", erro.Message);
                    _contexto.Rollback();

                }

            }
            return Json(ModelState.ToDataSourceResult());

        }

        public ActionResult Excluir([DataSourceRequest] DataSourceRequest request, IrmaoViewModel item)
        {
            try
            {
                _contexto.Irmoes.Remove(_contexto.Irmoes.Find(item.IrmaoId));
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