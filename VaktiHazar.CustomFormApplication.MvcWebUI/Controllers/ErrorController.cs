using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VaktiHazar.CustomFormApplication.MvcWebUI.Controllers
{
    public class ErrorController : BaseController
    {
        // GET: Error
        public ActionResult Index(string errorHeader, string errorMessage)
        {
            if (!IsLoggedOn())
                return RedirectToAction("Index", "Login");

            ViewBag.ErrorHeader = errorHeader;
            ViewBag.ErrorMessage = errorMessage;
            return View();
        }
    }
}