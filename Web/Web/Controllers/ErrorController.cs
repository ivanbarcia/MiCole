﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/Shared/Error/Error.cshtml");
        }

        public ActionResult HttpError404(string error)
        {
            ViewData["Title"] = "Sorry, an error occurred while processing your request. (404)";
            ViewData["Description"] = error;
            return View("~/Views/Shared/Error/NotFound.cshtml");
        }

        public ActionResult HttpError500(string error)
        {
            ViewData["Title"] = "Sorry, an error occurred while processing your request. (500)";
            ViewData["Description"] = error;
            return View("~/Views/Shared/Error/PermissionDenied.cshtml");
        }


        public ActionResult General(string error)
        {
            ViewData["Title"] = "Sorry, an error occurred while processing your request.";
            ViewData["Description"] = error;
            return View("~/Views/Shared/Error/Error.cshtml");
        }
    }
}
