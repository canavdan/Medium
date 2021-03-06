﻿using MediumAppMP.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MediumAppMP.Core.DataAccess.EntityFramework
{
    public interface IEntityRepository<T> where T : class, IBaseEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
