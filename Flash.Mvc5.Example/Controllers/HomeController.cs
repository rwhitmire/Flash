using System.Web.Mvc;

namespace Flash.Mvc5.Example.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            Request.Flash("success", "message");
            Request.Flash("error", "message");
            return RedirectToAction("index");
        }
    }
}