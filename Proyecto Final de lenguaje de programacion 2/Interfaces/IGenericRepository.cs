using System;
using System.Collections.Generic;

namespace Proyecto_Final_de_lenguaje_de_programacion_2.Interfaces
{
    public interface IGenericRepository<T>
    {
        T Create (T model);
        List<T> getAll();
        T getById(int Id);
        OperationResult Update (T model);
        OperationResult Delete (T model);
    }
}
