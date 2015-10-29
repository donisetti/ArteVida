using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArteVida.Dominio.Contexto;
using ArteVida.Dominio.Repositorio;
using ArteVida.GestorWeb.ViewModels;

namespace ArteVida.GestorWeb.Controllers.Cadastros
{
    public class DiretoriaController : Controller
    {
        private DbContexto _contexto;
        private RepositorioAtleta _repositorio;

        private int _Id;

        public DiretoriaController()
        {
            _contexto = new DbContexto();
            _repositorio = new RepositorioAtleta(_contexto);
        }


        // GET: Diretoria
        public ActionResult Index()
        {
            var model = new JanelaViewModel("Diretoria");           
            return View("_ConsultaBase", model);
        }

       
    }
}