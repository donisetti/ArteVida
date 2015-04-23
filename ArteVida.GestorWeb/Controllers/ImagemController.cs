using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArteVida.Dominio.Entidades;
using ArteVida.GestorWeb.ViewModels;

namespace ArteVida.GestorWeb.Controllers
{
    public class ImagemController : Controller
    {
        // GET: Imagem
        public ActionResult Index()
        {
            return View();
        }

        // GET: Imagem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Imagem/Create
        public ActionResult Create()
        {
            return View(new ImagemViewModel());
        }

     

        // GET: Imagem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Imagem/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Imagem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Imagem/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
