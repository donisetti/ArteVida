using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArteVida.Dominio.Contexto;
using ArteVida.Dominio.Repositorio;
using ArteVida.GestorWeb.ViewModels;
using AutoMapper.QueryableExtensions;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace ArteVida.GestorWeb.Controllers.Cadastros
{
    public class DiretoriaController : Controller
    {
        private DbContexto _contexto;
        private RepositorioDiretoria _repositorio;

        private int _Id;

        public DiretoriaController()
        {
            _contexto = new DbContexto();
            _repositorio = new RepositorioDiretoria(_contexto);
        }


        // GET: Diretoria
        public ActionResult Index()
        {
            var model = new JanelaViewModel("Diretoria");           
            return View("_ConsultaBase", model);
        }

        public ActionResult Ler([DataSourceRequest] DataSourceRequest request)
        {
            return Json(PegarDiretores().ToDataSourceResult(request));
        }



        private IQueryable<DiretoriaViewModel> PegarDiretores(string tipo = "Todos")
        {
            if (tipo != "Todos")
            {

                var dados = _repositorio.ObterTodos().ProjectTo<DiretoriaViewModel>();


                return dados;
            }
            else
            {

                var dados = _repositorio.ObterTodos().ProjectTo<DiretoriaViewModel>();


                return dados;

            }
        }
    }
}