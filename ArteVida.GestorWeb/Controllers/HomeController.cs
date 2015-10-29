using System.Web.Mvc;

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
            ViewBag.Versao = "Arte e Vida : 1.00.12 - 29/10/2015 16:30 ";
            return View();
        }

       
    }
}