using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VaktiHazar.CustomFormApplication.Entities.Concrete;

namespace VaktiHazar.CustomFormApplication.MvcWebUI.Models
{
    public class FormAddViewModel
    {
        public Form Form { get; set; }

        public FormAddViewModel()
        {
            this.Form = new Form();
        }

        public ICollection<string> FieldTypes { get; set; }
        public ICollection<string> FieldNames { get; set; }
        public ICollection<string> FieldRequiredStatuses { get; set; }
    }
}