﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VaktiHazar.CustomFormApplication.Entities.Concrete;

namespace VaktiHazar.CustomFormApplication.Business.Abstract
{
    public interface IUserService : IEntityRepositoryService<User>
    {
        bool IsExistUsername(Expression<Func<User, bool>> filter);
    }
}
