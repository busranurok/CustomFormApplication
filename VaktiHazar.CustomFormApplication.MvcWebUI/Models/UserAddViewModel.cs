using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VaktiHazar.CustomFormApplication.Entities.Concrete;

namespace VaktiHazar.CustomFormApplication.MvcWebUI.Models
{
    public class UserAddViewModel
    {
        public User User { get; set; }

        public UserAddViewModel()
        {
            this.User = new User();
        }
    }
}