using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VaktiHazar.CustomFormApplication.DataAccess.Concrete.EntityFramework;

namespace VaktiHazar.CustomFormApplication.MvcWebUI.Controllers
{
    public class LoginController : Controller
    {
        CustomFormApplicationContext _context = new CustomFormApplicationContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Logon(String userName, String password)
        {
            Entities.Concrete.User user = _context.Users.FirstOrDefault(u => u.Password == password && u.Username == userName);

            if (user != null)
            {
                Session["CurrentUser"] = user;
                return RedirectToAction(actionName: "ListUser", controllerName: "User");
            }

            else
            {
                ViewBag.Message = "Giriş Hatalı!";
                return View();
            }

        }
    }
}