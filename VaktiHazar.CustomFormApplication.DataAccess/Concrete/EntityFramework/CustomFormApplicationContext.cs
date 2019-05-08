using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using VaktiHazar.CustomFormApplication.Entities.Concrete;

namespace VaktiHazar.CustomFormApplication.DataAccess.Concrete.EntityFramework
{
    public class CustomFormApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<FormElement> FormElemets { get; set; }

        //connectionstring nesnesi
        public CustomFormApplicationContext() : base("CustomFormApplication")
        {

        }
    }
}
