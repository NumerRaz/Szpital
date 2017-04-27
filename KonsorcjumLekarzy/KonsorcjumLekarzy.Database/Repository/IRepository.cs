﻿using System.Collections.Generic;

namespace KonsorcjumLekarzy.Database.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(object ID);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}