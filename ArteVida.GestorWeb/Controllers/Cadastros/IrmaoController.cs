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
using Microsoft.Owin.Security.DataHandler.Encoder;

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

        public ActionResult LerIrmaoAtleta([DataSourceRequest] DataSourceRequest request, int atletaId)
        {
            _AtletaId = atletaId;
            return Json(PegarIrmaos().ToDataSourceResult(request));
        }
        
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



        //public ActionResult IncluirIrmaoAtleta([DataSourceRequest] DataSourceRequest request, IrmaoViewModel item)
        //{
        //    return IncluirIrmaoAtleta(request, item,0);
        //}

        [HttpPost]
        public ActionResult IncluirIrmaoAtleta(DataSourceRequest request, IrmaoViewModel item, int atletaId)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Irmao dados = Mapper.Map<Irmao>(item);                  
                    dados.Atleta = _contexto.Atletas.Find(atletaId);
                    _repositorio.Inserir(dados);
                    _contexto.SaveChanges();
                    item.IrmaoId = dados.IrmaoId;
                }
                catch (Exception erro)
                {                   
                    ModelState.AddModelError("", erro.Message);
                    _contexto.Rollback();
                    return Json(ModelState.ToDataSourceResult());
                }
            }

            return Json(new[] {item}.ToDataSourceResult(request, ModelState));
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

        public ActionResult ExcluirIrmaoAtleta([DataSourceRequest] DataSourceRequest request, IrmaoViewModel item)
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