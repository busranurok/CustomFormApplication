using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VaktiHazar.CustomFormApplication.MvcWebUI.Controllers
{
    public class BaseController : Controller
    {
        public bool IsLoggedOn()
        {
            var result = false;
            if (Session["CurrentUser"] !=null)
                result = true;

            return result;
        }
    }
}