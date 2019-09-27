using Web.DAL.Models;
using Web.Resources;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Web.Controllers
{
    [HandleError]
    public class LoginController : BaseController
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
            return RedirectToAction("Index", "Alumno");

            var firstLoggingCookie = Request.Cookies["FirstLogin"];

            if (firstLoggingCookie != null)
            {
                var expiredCookie = Request.Cookies[".ADAuthCookie"];

                if (expiredCookie == null)
                {
                    ModelState.AddModelError("", Global.Error_ExpiredMessage);
                }
            }

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model, string returnUrl)
        {
            var authenticationMode = 0;
            Session["Usuario"] = model.UserName;
            try
            {
                authenticationMode = Convert.ToInt32(ConfigurationManager.AppSettings["AuthenticationMode"]);
            }
            catch
            {
                authenticationMode = 0;
            }

            var cookie = new HttpCookie("FirstLogin");
            Response.Cookies.Add(cookie);

            //switch (authenticationMode)
            //{
            //    case 0:
            //        // LOGIN DEFAULT
            //        if (ModelState.IsValid)
            //        {
            //            if (UnitOfWork.Usuario.Any(x => x.NombreUsuario == model.UserName))
            //            {
            //                if (UnitOfWork.Usuario.GetByName(model.UserName).Estado == (int)States.Inactive)
            //                {
            //                    ModelState.AddModelError(string.Empty, Global.Login_InactiveUser);
            //                    break;
            //                }

            //                var passwordEncrypted = UnitOfWork.Usuario.Md5Encryption(model.Password);
            //                var currentPassword = UnitOfWork.Usuario.GetByName(model.UserName).Contraseña;

            //                if (passwordEncrypted != currentPassword)
            //                {
            //                    ModelState.AddModelError(string.Empty, Global.Login_InvalidUser);
            //                    break;
            //                }

            //                FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);

            //                return RedirectToAction("Index", "Home");
            //            }

            //            ModelState.AddModelError(string.Empty, Global.Login_InvalidUser);
            //        }
            //        break;

            //    case 1:
            //        return RedirectToAction("Index", "Home");

            //    case 2:
            //        // ACTIVE DIRECTORY
            //        if (!this.ModelState.IsValid)
            //        {
            //            return this.View(model);
            //        }

            //        try
            //        {
            //            GetADUser(model);

            //            FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);

            //            if (this.Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
            //                && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
            //            {
            //                return this.Redirect(returnUrl);
            //            }

            //            return this.RedirectToAction("Index", "Home");
            //        }
            //        catch (Exception ex)
            //        {
            //            this.ModelState.AddModelError(string.Empty, ex.Message);

            //            return View(model);
            //        }

            //        this.ModelState.AddModelError(string.Empty, Global.Login_InvalidUser);

            //        return View(model);

            //    case 3:
            //        // LDAP
            //        if (!this.ModelState.IsValid)
            //        {
            //            return this.View(model);
            //        }

            //        if (Membership.ValidateUser(model.UserName, model.Password))
            //        {
            //            GetADUser(model);

            //            FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);

            //            if (this.Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
            //                && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
            //            {
            //                return this.Redirect(returnUrl);
            //            }

            //            return this.RedirectToAction("Index", "Home");
            //        }

            //        this.ModelState.AddModelError(string.Empty, Global.Login_InvalidUser);

            //        return View(model);

            //    default:
            //        // LOGIN DEFAULT
            //        if (ModelState.IsValid)
            //        {
            //            if (UnitOfWork.Usuario.Any(x => x.NombreUsuario == model.UserName))
            //            {
            //                if (UnitOfWork.Usuario.GetByName(model.UserName).Estado == (int)States.Inactive)
            //                {
            //                    ModelState.AddModelError(string.Empty, Global.Login_InactiveUser);
            //                    break;
            //                }
            //                var passwordEncrypted = UnitOfWork.Usuario.Md5Encryption(model.Password);
            //                var currentPassword = UnitOfWork.Usuario.GetByName(model.UserName).Contraseña;
            //                if (passwordEncrypted != currentPassword)
            //                {
            //                    ModelState.AddModelError(string.Empty, Global.Login_InvalidUser);
            //                    break;
            //                }

            //                FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
            //                return RedirectToAction("Index", "Home");
            //            }

            //            ModelState.AddModelError(string.Empty, Global.Login_InvalidUser);
            //        }
            //        break;

            //}

            return this.View(model);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();

            var cookie1 = new HttpCookie(FormsAuthentication.FormsCookieName, "") { Expires = DateTime.Now.AddYears(-1) };
            Response.Cookies.Add(cookie1);

            var cookie2 = new HttpCookie("ASP.NET_SessionId", "") { Expires = DateTime.Now.AddYears(-1) };
            Response.Cookies.Add(cookie2);

            var cookie3 = new HttpCookie("FirstLogin", "") { Expires = DateTime.Now.AddYears(-1) };
            Response.Cookies.Add(cookie3);

            FormsAuthentication.RedirectToLoginPage();

            return RedirectToAction("Login", "Login");
        }
    }
}
