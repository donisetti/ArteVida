﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArteVida.GestorWeb.ViewModels;

namespace ArteVida.GestorWeb.Controllers.Cadastros
{
    public class InstrutorController : Controller
    {
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
    }
}