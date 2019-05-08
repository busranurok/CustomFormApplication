using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VaktiHazar.CustomFormApplication.Business.Abstract;
using VaktiHazar.CustomFormApplication.DataAccess.Concrete.EntityFramework;
using VaktiHazar.CustomFormApplication.Entities.Concrete;

namespace VaktiHazar.CustomFormApplication.Business.Concrete.Managers
{
    public class UserManager : IEntityRepositoryService<User>, IUserService
    {
        EfUserDal _userDal = new EfUserDal();

        public User Add(User entity)
        {
            return _userDal.Add(entity);
        }

        public void Delete(User entity)
        {
            _userDal.Delete(entity);
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            return _userDal.Get(filter);
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            return _userDal.GetAll(filter);
        }

        public bool IsExistUsername(Expression<Func<User, bool>> filter)
        {
            return _userDal.IsExistUsername(filter);
        }

        public User Update(User entity)
        {
            return _userDal.Update(entity);
        }
    }
}
