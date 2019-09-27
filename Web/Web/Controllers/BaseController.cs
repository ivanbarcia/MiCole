using System.Web.Mvc;
using Web.Filters;
//using NLog;

namespace Web.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        //protected virtual new CustomPrincipal User
        //{
        //    get { return HttpContext.User as CustomPrincipal; }
        //}

        protected override void OnException(ExceptionContext filterContext)
        {
            //DefaultLogger.Log(filterContext.Exception.Message, filterContext.Exception);
            //Logger.Error(filterContext.Exception, filterContext.Controller.ControllerContext.RouteData.Values["controller"] + " || " + filterContext.Controller.ControllerContext.RouteData.Values["action"]);

            if (filterContext.ExceptionHandled)
            {
                return;
            }

            // Do additional things like logging here.
            base.OnException(filterContext);

            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult()
            {
                ViewName = "/Error"
            };

            filterContext.Result = new RedirectResult("/Error");
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
    }
}
