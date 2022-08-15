﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Proyecto_Final_de_lenguaje_de_programacion_2.Data.Entities;
using Proyecto_Final_de_lenguaje_de_programacion_2.Interfaces;

namespace Proyecto_Final_de_lenguaje_de_programacion_2.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private incDbContext _dbContext;
        private DbSet<T> _set;

        public GenericRepository()
        {
            _dbContext = new incDbContext();
            _set = _dbContext.Set<T>();
        }
        public T Create(T model)
        {
            _dbContext.Entry(model).State = EntityState.Added;
            _dbContext.SaveChanges();

            return model;
        }

        public OperationResult Delete(T model)
        {
            _dbContext.Entry(_set).State = EntityState.Modified;
            model.Borrado = 1;
            model.Estatus = "I";
            model.FechaModificacion = DateTime.Today;


            _dbContext.SaveChanges();
            return new OperationResult() { Succes = true };
        }

        public List<T> getAll()
        {
            return _set.Where(f => f.Borrado == 0 && f.Estatus == "A").ToList();
        }

        public T getById(int Id)
        {
            _set.FirstOrDefault(x => x.Id == Id);
        }

        public OperationResult Update(T model)
        {
           _dbContext.Entry(model).State = EntityState.Modified;
           _dbContext.SaveChanges();

            return new OperationResult() { Succes = true };

        }
    }
}