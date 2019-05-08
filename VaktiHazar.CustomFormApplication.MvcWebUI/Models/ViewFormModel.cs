using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VaktiHazar.CustomFormApplication.Entities.Concrete;

namespace VaktiHazar.CustomFormApplication.MvcWebUI.Models
{
    public class ViewFormModel
    {
        public List<FormElement> FormElement{ get; set; }
        public Form Form { get; set; }
    }
}