using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VaktiHazar.CustomFormApplication.Business.Concrete.Managers;
using VaktiHazar.CustomFormApplication.Entities.Concrete;
using VaktiHazar.CustomFormApplication.MvcWebUI.Models;

namespace VaktiHazar.CustomFormApplication.MvcWebUI.Controllers
{
    public class FormController : BaseController
    {
        [HttpGet]
        public ActionResult ListForm()
        {
            if (!IsLoggedOn())
                return RedirectToAction("Index", "Login");

            var formList = new FormManager().GetAll();
            return View(formList);
        }


        [HttpGet]
        public ActionResult AddForm(int id = 0)
        {
            if (!IsLoggedOn())
                return RedirectToAction("Index", "Login");

            FormAddViewModel model = new FormAddViewModel();
            ViewBag.FieldCount = 0;
            ViewBag.FormId = id;

            if (id != 0)
            {
                var form = new FormManager().Get(x => x.FormId == id);
                model.Form = form;

                var formElements = new FormElementManager().GetAll(x => x.FormId == id);
                ViewBag.FieldCount = formElements.Count;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult AddForm(FormAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (model.Form.FormId != 0)
                    {
                        var form = new FormManager().Get(f => f.FormId == model.Form.FormId);
                        form.FormName = model.Form.FormName;
                        form.FormDescription = model.Form.FormDescription;
                        form.FormCreatedDate = DateTime.Now;
                        form.FormCreatedUser = ((User)Session["CurrentUser"]).UserId;
                        new FormManager().Update(form);
                    }
                    else
                    {
                        model.Form.FormCreatedDate = DateTime.Now;
                        model.Form.FormCreatedUser = ((User)Session["CurrentUser"]).UserId;
                        var form= new FormManager().Add(model.Form);
                        var formElementManager = new FormElementManager();

                        for (int i = 0; i < model.FieldRequiredStatuses.Count; i++)
                        {
                            var formElement= new FormElement();
                            formElement.FormId = form.FormId;
                            formElement.FormElementDataType = model.FieldTypes.ElementAt(i);
                            formElement.FormElementName = model.FieldNames.ElementAt(i);
                            formElement.IsRequired8 = model.FieldNames.ElementAt(i) == "True" ? true : false;

                            formElementManager.Add(formElement);
                        }
                    }

                    return RedirectToAction("ListForm","Form");
                }
                catch (Exception exception)
                {
                    return RedirectToAction("Index","Error", new { errorHeader = "Model Hatası", errorMessage = "Form eklenirken hata oluştu :"+exception.StackTrace });
                }
            }
            else
            {
                return RedirectToAction("Index", "Error", new { errorHeader="Model Hatası", errorMessage="Form eklenirken model uyuşmadı" });
            }
        }

        [HttpGet]
        public ActionResult GetFormFields(int formId)
        {
            var form = new FormManager().Get(f => f.FormId == formId);
            var result = new FormAddViewModel();
            List<FormElement> formElements = new FormElementManager().GetAll(x => x.FormId == formId);
            return Json(formElements,JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult DeleteForm(int id)
        {
            var form = new FormManager().Get(f => f.FormId == id);
            new FormManager().Delete(form);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult FormDetails(int id)
        {
            if (!IsLoggedOn())
                return RedirectToAction("Index", "Login");

            var model = new FormManager().Get(m => m.FormId == id);
            return View(model);
        }

        public ActionResult ViewForm(int id)
        {
            if (!IsLoggedOn())
                return RedirectToAction("Index", "Login");

            var form = new FormManager().Get(x => x.FormId == id);
            var formElementList = new FormElementManager().GetAll(x => x.FormId == id);

            var model = new ViewFormModel();
            model.Form = form;
            model.FormElement = formElementList;
            return View(model);
        }
    }
}