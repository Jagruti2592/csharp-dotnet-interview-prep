using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInventorySystem.Repository
{
    internal interface IRepository<T>
    {
        void Add(T item);
        void Remove(int id);
        T getById(int id);

        List<T> GetAll();
        void Update(T item);

    }
}
