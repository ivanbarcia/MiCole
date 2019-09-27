using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using System.Linq;
using System.Web;

namespace Web.Helpers
{
    public static class HtmlExtensions
    {

        public static MvcHtmlString ActionLinkUrlParam(this HtmlHelper helper, string linkText, string actionName, object routeValues = null, object htmlAttributes = null)
        {
            MvcHtmlString link;
            RouteValueDictionary val = new RouteValueDictionary();

            if (routeValues != null)
            {
                val = new RouteValueDictionary(routeValues);
            }

            if (helper.ViewContext.HttpContext.Request.UrlReferrer.Query != "")
            {
                string[] results = helper.ViewContext.HttpContext.Request.UrlReferrer.Query.Replace("?", "").Replace("%2F", "/").Replace("%2f", "/").Replace("+", " ").Split(new string[] { "&" }, StringSplitOptions.RemoveEmptyEntries);

                if (results.Length > 0)
                {
                    foreach (var item in results)
                    {
                        val.Add(item.Split(new Char[] { '=' })[0], item.Split(new Char[] { '=' })[1]);
                    }
                }
            }

            Dictionary<string, object> html = new Dictionary<string, object>();
            if (htmlAttributes == null)
            {
                html.Add("class", "form-control");
                link = System.Web.Mvc.Html.LinkExtensions.ActionLink(helper, linkText, actionName, val, html);
            }
            else
            {
                html.Add("type", "button");
                html.Add("class", "btn btn-primary");

                link = System.Web.Mvc.Html.LinkExtensions.ActionLink(helper, linkText, actionName, val, html);
            }

            return link;
        }

        // As the text the: "<span class='glyphicon glyphicon-plus'></span>" can be entered
        public static MvcHtmlString NoEncodeActionLink(this HtmlHelper htmlHelper,
                                             string text, string title, string action,
                                             string controller,
                                             object routeValues = null,
                                             object htmlAttributes = null)
        {
            UrlHelper urlHelper = new UrlHelper(htmlHelper.ViewContext.RequestContext);

            TagBuilder builder = new TagBuilder("a");
            builder.InnerHtml = text;
            builder.Attributes["title"] = title;
            builder.Attributes["href"] = urlHelper.Action(action, controller, routeValues);
            builder.MergeAttributes(new RouteValueDictionary(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes)));

            return MvcHtmlString.Create(builder.ToString());
        }
    }
}