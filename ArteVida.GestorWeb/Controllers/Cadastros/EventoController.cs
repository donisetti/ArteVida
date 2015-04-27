using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArteVida.GestorWeb.ViewModels;

namespace ArteVida.GestorWeb.Controllers.Cadastros
{
    public class EventoController : Controller
    {
        // GET: Evento
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Consulta()
        {

            var model = new JanelaViewModel { Titulo = "Cadastro de Eventos", Relatorio = "ListagemEventos.trdx", Tela = "_GridEventos" };
            return View("_ConsultaBase", model);
        }
    }
}