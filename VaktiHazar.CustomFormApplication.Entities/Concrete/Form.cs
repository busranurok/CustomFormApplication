using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaktiHazar.CustomFormApplication.Entities.Abstract;

namespace VaktiHazar.CustomFormApplication.Entities.Concrete
{
    public class Form : IEntity
    {
        [DisplayName("Form Id")]
        public int FormId { get; set; }
        [DisplayName("Form Name")]
        public string FormName { get; set; }
        [DisplayName("Form Açıklaması")]
        public string FormDescription { get; set; }
        [DisplayName("Form Oluşturma Zamanı")]
        public DateTime FormCreatedDate { get; set; }
        [DisplayName("Formu Oluşturan Kullanıcı")]
        public int FormCreatedUser { get; set; }
        public virtual User User { get; set; }
    }
}
