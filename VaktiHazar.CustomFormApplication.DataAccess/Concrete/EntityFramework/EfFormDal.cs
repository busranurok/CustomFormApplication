using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaktiHazar.CustomFormApplication.DataAccess.Abstract;
using VaktiHazar.CustomFormApplication.Entities.Concrete;

namespace VaktiHazar.CustomFormApplication.DataAccess.Concrete.EntityFramework
{
    public class EfFormDal : EfEntityRepositoryBase<Form, CustomFormApplicationContext>, IFormDal
    {
    }
}
