using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace TaonyNet.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TaonyNetControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}