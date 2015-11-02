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
            ViewBag.Versao = "Arte e Vida : 1.00.13 - 02/11/2015 17:30";
            return View();
        }

       
    }
}