using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace TaonyNet.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
	}
}