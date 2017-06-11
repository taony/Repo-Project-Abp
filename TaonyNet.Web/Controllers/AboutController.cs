using System.Web.Mvc;

namespace TaonyNet.Web.Controllers
{
    public class AboutController : TaonyNetControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}