using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VaktiHazar.CustomFormApplication.Business.Concrete.Managers;
using VaktiHazar.CustomFormApplication.MvcWebUI.Models;

namespace VaktiHazar.CustomFormApplication.MvcWebUI.Controllers
{
    public class UserController : BaseController
    {
        [HttpGet]
        public ActionResult ListUser()
        {
            if (!IsLoggedOn())
                return RedirectToAction("Index", "Login");

            var userList = new UserManager().GetAll();
            return View(userList);
        }

        
        [HttpGet]
        public ActionResult AddUser(int id = 0)
        {
            if (!IsLoggedOn())
                return RedirectToAction("Index", "Login");

            UserAddViewModel model = new UserAddViewModel();

            if (id != 0)
            {
                var user = new UserManager().Get(x => x.UserId == id);
                model.User = user;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult AddUser(UserAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (model.User.UserId != 0)
                    {
                        var user = new UserManager().Get(u => u.UserId == model.User.UserId);
                        user.Name = model.User.Name;
                        user.Lastname = model.User.Lastname;
                        user.Username = model.User.Username;
                        user.Email = model.User.Email;
                        user.Password = model.User.Password;
                        new UserManager().Update(user);
                    }
                    else
                    {
                        new UserManager().Add(model.User);
                    }

                    return RedirectToAction("ListUser","User");
                }
                catch (Exception exception)
                {
                    ViewBag.Message = exception.Message;
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Index","Error",new { errorHeader="İşlem yapılırken hata oluştu", errorMessage="Kullanıcı kaydetme işlemi yapılırken hata oluştu lütfen sistem yöneticinize başvurun" });
            }
        }

        [HttpGet]
        public ActionResult DeleteUser(int id)
        {
            var user = new UserManager().Get(x => x.UserId == id);
            new UserManager().Delete(user);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UserDetails(int id)
        {
            if (!IsLoggedOn())
                return RedirectToAction("Index", "Login");

            var model = new UserManager().Get(m => m.UserId == id);
            return View(model);
        }
    }
}