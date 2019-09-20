using eDrago.BLL.Business;
using eDrago.BLL.Interfaces;
using eDrago.DAL.Models;
using eDrago.Resources;
using System;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace eDrago.Controllers
{
    [HandleError]
    public class LoginController : BaseController
    {
        public readonly ILoginBusiness _loginBusiness;

        public LoginController(/*ILoginBusiness loginBusiness*/)
        {
            _loginBusiness = new LoginBusiness();//loginBusiness;
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "UserName,Password")] Login model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var login = _loginBusiness.Login(model);

                if (login != null)
                {
                    if (!checkSesionActiva(login.Usuario))
                    {
                        ModelState.AddModelError(string.Empty, Global.ErrorSesionesActivas);
                        return View(model);
                    }

                    SetAuthenticationData(login);

                    // Log
                    //_seguridadBusiness.GetPortalLog(cliente.Usuario, 3);

                    if (login.RenovarClave == 1)
                    {
                        // El cliente tiene su contraseña vencida
                        return RedirectToAction("ChangePassword", "Account", new { id = 1, cuit = login.Usuario });
                    }

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Usuario o Contraseña incorrecta");

                    if (Session["IntentosFallidos"] == null)
                    {
                        Session["IntentosFallidos"] = 0;
                    }

                    if ((int)Session["IntentosFallidos"] != 2)
                    {
                        Session["IntentosFallidos"] = (int)Session["IntentosFallidos"] + 1;
                    }
                }
            }

            return View(model);
        }

        private void SetAuthenticationData(ClienteLogin user)
        {
            //CustomPrincipalSerializeModel serializeModel = new CustomPrincipalSerializeModel();
            //serializeModel.Id = user.Id;
            //serializeModel.ClieAlias = user.clie_alias;
            ////serializeModel.Cuenta = user.Cuenta;
            //serializeModel.FirstName = user.Usuario.Trim();
            //serializeModel.LastName = user.NombreAfip.Trim();
            //serializeModel.Email = user.Email;

            //JavaScriptSerializer serializer = new JavaScriptSerializer();

            //string userData = serializer.Serialize(serializeModel);

            //FormsAuthentication.SetAuthCookie(userData, false);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();

            var cookie1 = new HttpCookie(FormsAuthentication.FormsCookieName, "") { Expires = DateTime.Now.AddYears(-1) };
            Response.Cookies.Add(cookie1);

            var cookie2 = new HttpCookie("SessionId", "") { Expires = DateTime.Now.AddYears(-1) };
            Response.Cookies.Add(cookie2);

            var cookie3 = new HttpCookie("JWT", "") { Expires = DateTime.Now.AddYears(-1) };
            Response.Cookies.Add(cookie3);

            var cookie4 = new HttpCookie("Token", "") { Expires = DateTime.Now.AddYears(-1) };
            Response.Cookies.Add(cookie4);

            var cookie5 = new HttpCookie("Refresh_Token", "") { Expires = DateTime.Now.AddYears(-1) };
            Response.Cookies.Add(cookie5);

            FormsAuthentication.RedirectToLoginPage();

            return RedirectToAction("Login", "Login");
        }

        protected bool checkSesionActiva(string userName)
        {
            System.Collections.Generic.List<string> d = HttpContext.Application["UsersLoggedIn"] as System.Collections.Generic.List<string>;
            if (d != null)
            {
                lock (d)
                {
                    if (d.Contains(userName))
                    {
                        int cant = d.Count(s => userName.Contains(s));
                        if (Convert.ToInt32(ConfigurationManager.AppSettings["CantidadIntentosFallidos"]) <= cant)
                        {
                            return false;
                        }
                    }
                    d.Add(userName);
                }
            }
            Session["UserLoggedIn"] = userName;
            return true;
        }
    }
}
