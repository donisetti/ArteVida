using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArteVida.GestorWeb.ViewModels;

namespace ArteVida.GestorWeb.Controllers
{
    public class ListagemGeralController : Controller
    {
        // GET: ListagemGeral
        public ActionResult Atletas()
        {
            var model = new JanelaViewModel { Titulo = "Listagem de Atletas", Relatorio = "ListagemAtletas.trdx", Tela = "_ListaTabAuxiliar" };
            return View("_RelatorioBase", model);

         

        }


    }
}