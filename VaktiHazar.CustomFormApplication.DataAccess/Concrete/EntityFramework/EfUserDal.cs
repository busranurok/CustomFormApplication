using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VaktiHazar.CustomFormApplication.DataAccess.Abstract;
using VaktiHazar.CustomFormApplication.Entities.Concrete;

namespace VaktiHazar.CustomFormApplication.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CustomFormApplicationContext>, IUserDal
    {
        public bool IsExistUsername(Expression<Func<User, bool>> filter)
        {
            bool result = false;
            using (var context = new CustomFormApplicationContext())
            {
                result = context.Users.FirstOrDefault(filter) == null ? false : true;
            }
            return result;
        }
    }
}
