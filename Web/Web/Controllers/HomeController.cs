using System.Linq;
using System.Web.Mvc;
using System;
using Web.Resources;
using System.Web;

namespace Web.Controllers
{
    public class HomeController : BaseController
    {
        [Authorize]
        //[OutputCache(Duration = 3600, VaryByParam = "none")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
