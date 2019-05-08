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
    public class FormManager : IEntityRepositoryService<Form>, IFormService
    {
        EfFormDal _formDal = new EfFormDal();

        public Form Add(Form entity)
        {
            return _formDal.Add(entity);
        }

        public void Delete(Form entity)
        {
            _formDal.Delete(entity);
        }

        public Form Get(Expression<Func<Form, bool>> filter)
        {
            return _formDal.Get(filter);
        }

        public List<Form> GetAll(Expression<Func<Form, bool>> filter = null)
        {
            return _formDal.GetAll(filter);
        }

        public Form Update(Form entity)
        {
            return _formDal.Update(entity);
        }
    }
}
