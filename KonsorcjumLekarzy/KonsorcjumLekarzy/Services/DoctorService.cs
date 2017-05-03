﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KonsorcjumLekarzy.Database.Repository;
using KonsorcjumLekarzy.Database.Model;

namespace KonsorcjumLekarzy.Services
{
    public class DoctorService : IGenericService<Doctor>
    {
        private readonly IRepository<Doctor> _repository;
        
        public DoctorService(IRepository<Doctor> repository)
        {
            this._repository = repository;
        }

        public IList<Doctor> EntietiesList()
        {
            return _repository.GetAll().ToList();
        }

        public void AddEntity(Doctor entity)
        {
            this._repository.Insert(entity);
        }

        public void UpdateEntity(Doctor entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Doctor entity)
        {
            throw new NotImplementedException();
        }

        public void GetEntiyById(int id)
        {
            throw new NotImplementedException();
        }
    }
}