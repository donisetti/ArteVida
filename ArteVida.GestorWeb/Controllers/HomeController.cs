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
            ViewBag.Versao = "Arte e Vida : 1.00.7 - 01/06/2015 09:40 ";

            //ViewBag.Extenso = Extenso.ToExtenso(245765.32, Extenso.TipoValorExtenso.Monetario);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}