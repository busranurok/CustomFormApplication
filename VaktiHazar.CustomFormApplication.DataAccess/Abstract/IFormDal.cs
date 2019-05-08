using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaktiHazar.CustomFormApplication.Entities.Concrete;

namespace VaktiHazar.CustomFormApplication.DataAccess.Abstract
{
    public interface IFormDal : IEntityRepository<Form>
    {
    }
}
