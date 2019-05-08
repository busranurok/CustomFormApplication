using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaktiHazar.CustomFormApplication.Entities.Abstract;

namespace VaktiHazar.CustomFormApplication.Entities.Concrete
{
    public class FormElement : IEntity
    {
        [DisplayName("Form Elementinin Id si")]
        public int FormElementId { get; set; }
        [DisplayName("Form Id")]
        public int FormId { get; set; }
        public virtual Form Form { get; set; }
        [DisplayName("Zorunlu Alan Mı?")]
        public bool IsRequired8 { get; set; }
        [DisplayName("Form Elementinin Adı")]
        public string FormElementName { get; set; }
        [DisplayName("Form Elementinin Veri Türü")]
        public string FormElementDataType { get; set; }
    }
}
