using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaktiHazar.CustomFormApplication.Business.Abstract;
using VaktiHazar.CustomFormApplication.DataAccess.Concrete.EntityFramework;
using VaktiHazar.CustomFormApplication.Entities.Concrete;

namespace VaktiHazar.CustomFormApplication.Business.Concrete.Managers
{
    public class FormElementManager : IEntityRepositoryService<FormElement>, IFormElementService
    {
        EfFormElementDal _formElementDal = new EfFormElementDal();

        public FormElement Add(FormElement entity)
        {
            return _formElementDal.Add(entity);
        }

        public void Delete(FormElement entity)
        {
            _formElementDal.Delete(entity);
        }

        public FormElement Get(System.Linq.Expressions.Expression<Func<FormElement, bool>> filter)
        {
            return _formElementDal.Get(filter);
        }

        public List<FormElement> GetAll(System.Linq.Expressions.Expression<Func<FormElement, bool>> filter = null)
        {
            return _formElementDal.GetAll(filter);
        }

        public FormElement Update(FormElement entity)
        {
            return _formElementDal.Update(entity);
        }
    }
}
