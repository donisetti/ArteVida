﻿using System.Web.Mvc;

namespace ArteVida.GestorWeb.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {


        public HomeController()
        {

        }

        public ActionResult Index()
        {
           // ViewBag.Versao = "Arte e Vida : 1.00.15 - 14/12/2015 11:40";
           // ViewBag.Versao = "Arte e Vida : 1.00.15 - 31/01/2016 18:20";
            ViewBag.Versao = "Arte e Vida : 1.00.16 - 13/10/2016 12:00";
            return View();
        }

       
    }
}