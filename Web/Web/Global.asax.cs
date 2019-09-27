using Web.App_Start;
using Web.Controllers;
using Web.DAL.Context;
using Web.Factory;
using Web.Filters;
using Web.Security;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Script.Serialization;
using System.Web.Security;
using Web.App_Start;

namespace Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            if (ServicePointManager.SecurityProtocol.HasFlag(SecurityProtocolType.Tls12) == false)
            {
                ServicePointManager.SecurityProtocol = ServicePointManager.SecurityProtocol | SecurityProtocolType.Tls12;
            }

            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ValueProviderFactories.Factories.Add(new JsonValueProviderFactory());

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());

            HtmlHelper.ClientValidationEnabled = true;
            HtmlHelper.UnobtrusiveJavaScriptEnabled = true;

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());

            ClientDataTypeModelValidatorProvider.ResourceClassKey = "Global";
            DefaultModelBinder.ResourceClassKey = "Global";

            Database.SetInitializer<DataContext>(null);

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-AR");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");

            //Unica sesion por usuario - Inicializo una coleccion para manejo de sesiones activas
            Application["UsersLoggedIn"] = new List<string>();

            AutoMapperConfig.Configure();
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var exception = Server.GetLastError();
            
            Response.Clear();

            var httpException = exception as HttpException;
            var routeData = new RouteData();
            routeData.Values.Add("controller", "Error");

            if (httpException == null)
            {
                routeData.Values.Add("action", "Index");
            }
            else //It's an Http Exception, Let's handle it.
            {
                switch (httpException.GetHttpCode())
                {
                    case 404:
                        // Page not found.
                        routeData.Values.Add("action", "HttpError404");
                        break;
                    case 500:
                        // Server error.
                        routeData.Values.Add("action", "HttpError500");
                        break;
                    // Here you can handle Views to other error codes.
                    // I choose a General error template  
                    default:
                        routeData.Values.Add("action", "General");
                        break;
                }
            }

            // Pass exception details to the target error View.
            routeData.Values.Add("Shared", exception);

            // Clear the error on server.
            Server.ClearError();

            // Call target Controller and pass the routeData.
            IController errorController = new ErrorController();
            errorController.Execute(new RequestContext(new HttpContextWrapper(Context), routeData));

        }
        protected void MvcApplication_PostAuthenticateRequest(object sender, EventArgs e)
        {
            var authCookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
            if (authCookie != null)
            {
                var encTicket = authCookie.Value;
                if (!String.IsNullOrEmpty(encTicket))
                {
                    var ticket = FormsAuthentication.Decrypt(encTicket);
                    var id = new UserIdentity(ticket);
                    var userRoles = Roles.GetRolesForUser(id.Name);
                    var prin = new GenericPrincipal(id, userRoles);
                    HttpContext.Current.User = prin;
                }
            }
        }

        protected void Application_PostAuthenticateRequest(Object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];

            if (authCookie != null)
            {
                FormsAuthenticationTicket authTicket = FormsAuthentication.Decrypt(authCookie.Value);

                JavaScriptSerializer serializer = new JavaScriptSerializer();

                //CustomPrincipalSerializeModel serializeModel = serializer.Deserialize<CustomPrincipalSerializeModel>(authTicket.Name);

                //CustomPrincipal newUser = new CustomPrincipal(authTicket.Name);
                //newUser.Id = serializeModel.Id;
                //newUser.ClieAlias = serializeModel.ClieAlias;
                //newUser.FirstName = serializeModel.FirstName;
                //newUser.LastName = serializeModel.LastName;
                //newUser.Email = serializeModel.Email;

                //HttpContext.Current.User = newUser;
            }
        }

        protected void Application_PostReleaseRequestState(object sender, EventArgs e)
        {
            // Implement HTTP compression
            HttpApplication app = (HttpApplication)sender;

            // Retrieve accepted encodings
            string encodings = app.Request.Headers.Get("Accept-Encoding");
            if (encodings != null)
            {
                // Check the browser accepts deflate or gzip (deflate takes preference)
                encodings = encodings.ToLower();
                if (encodings.Contains("deflate"))
                {
                    app.Response.Filter = new DeflateStream(app.Response.Filter, CompressionMode.Compress);
                    app.Response.AppendHeader("Content-Encoding", "deflate");
                }
                else if (encodings.Contains("gzip"))
                {
                    app.Response.Filter = new GZipStream(app.Response.Filter, CompressionMode.Compress);
                    app.Response.AppendHeader("Content-Encoding", "gzip");
                }
            }
        }

        protected void Session_End(object sender, EventArgs e)
        {
            string userLoggedIn = Session["UserLoggedIn"] == null ? string.Empty : (string)Session["UserLoggedIn"];
            if (userLoggedIn.Length > 0)
            {
                List<string> d = Application["UsersLoggedIn"] as List<string>;
                if (d != null)
                {
                    lock (d)
                    {
                        d.Remove(userLoggedIn);
                    }
                }
            }
        }
    }
}
