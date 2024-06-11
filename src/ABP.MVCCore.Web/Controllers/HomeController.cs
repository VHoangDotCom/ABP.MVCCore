using Microsoft.AspNetCore.Mvc;

namespace ABP.MVCCore.Web.Controllers
{
    public class HomeController : MVCCoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}