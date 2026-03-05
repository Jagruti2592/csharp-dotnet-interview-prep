using GenericInventorySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInventorySystem.Repository
{      //this class will implement the IRepository interface and provide the actual implementation for the methods defined in the interface.
       //It will use a List<T> to store the items in memory.
       //This is a simple implementation for demonstration purposes, and in a real-world application, you would typically use a database or other persistent storage.
    internal class GenericRepository<T>: IRepository<T> where T:IEntity
    {
        private List<T> items;

        public GenericRepository()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {

            items.Add(item);
        }

         public List<T> GetAll()
        {
            return items;
        }

        public T getById(int id)
        {
            return items.FirstOrDefault(items => items.Id == id);
        }

        public void Remove(int id) {

            var item = items.FirstOrDefault(item => item.Id == id);
                if(item != null)
            {
                items.Remove(item);
            }
        }

        public void Update(T item) {

            var existingItem = items.FirstOrDefault(items => items.Id == item.Id);
            if(existingItem != null)
            {
                int index = items.IndexOf(existingItem);
                items[index] = item;
            }
        }

    }
}
