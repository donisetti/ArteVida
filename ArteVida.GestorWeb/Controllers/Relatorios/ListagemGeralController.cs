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
            var model = new JanelaViewModel { Titulo = "Listagem de Atletas", Relatorio = "ListagemAtletas.trdx", Tela = "_ListaGeral" };
            return View("_RelatorioBase", model);
        }

        public ActionResult Instrutores()
        {
            var model = new JanelaViewModel { Titulo = "Listagem de Instrutores", Relatorio = "ListagemInstrutores.trdx", Tela = "_ListaGeral" };
            return View("_RelatorioBase", model);
        }

        public ActionResult Voluntarios()
        {
            var model = new JanelaViewModel { Titulo = "Listagem de Voluntários", Relatorio = "ListagemTeste.trdx", Tela = "_ListaGeral" };
            return View("_RelatorioBase", model);
        }

        public ActionResult Patrocinadores()
        {
            var model = new JanelaViewModel { Titulo = "Listagem de Patrocinadores", Relatorio = "ListagemTeste.trdx", Tela = "_ListaGeral" };
            return View("_RelatorioBase", model);
        }

        public ActionResult Socios()
        {
            var model = new JanelaViewModel { Titulo = "Listagem de Sócios", Relatorio = "ListagemTeste.trdx", Tela = "_ListaGeral" };
            return View("_RelatorioBase", model);
        }

        public ActionResult Diretoria()
        {
            var model = new JanelaViewModel { Titulo = "Listagem de Diretoria", Relatorio = "ListagemTeste.trdx", Tela = "_ListaGeral" };
            return View("_RelatorioBase", model);
        }


    }
}