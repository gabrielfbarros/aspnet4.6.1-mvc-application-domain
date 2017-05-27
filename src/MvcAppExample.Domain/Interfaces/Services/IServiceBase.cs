﻿using System;
using System.Collections.Generic;

namespace MvcAppExample.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> : IDisposable where TEntity : class
    {
        TEntity Add(TEntity entity);
        void Delete(Guid id);
        TEntity FindById(Guid id);
        IEnumerable<TEntity> GetAll();
        TEntity Update(TEntity entity);
    }
}
