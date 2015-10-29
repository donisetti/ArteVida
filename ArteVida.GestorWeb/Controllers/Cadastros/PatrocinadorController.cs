using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArteVida.GestorWeb.ViewModels;

namespace ArteVida.GestorWeb.Controllers.Cadastros
{
    public class PatrocinadorController : Controller
    {
        // GET: Patrocinador
        public ActionResult Index()
        {
            var model = new JanelaViewModel("Patrocinadores");
            return View("_ConsultaBase", model);
        }
    }
}