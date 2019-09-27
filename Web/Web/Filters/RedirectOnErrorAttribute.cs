using System.Web.Mvc;

namespace Web.Filters
{
    public class RedirectOnErrorAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            // Don't interfere if the exception is already handled
            if (filterContext.ExceptionHandled)
                return;

            //.. log exception and do appropriate redirects here
        }
    }
}