using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace TaonyNet.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}