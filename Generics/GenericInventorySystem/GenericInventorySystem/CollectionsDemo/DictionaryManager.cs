using GenericInventorySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInventorySystem.CollectionsDemo
{
    internal class DictionaryManager
    {
        private Dictionary<int, Product> products;

        public DictionaryManager()
        {
            products = new Dictionary<int, Product>();
        }

        public void AddProduct(Product product) { 
           if(products.ContainsKey(product.Id))
            {
                Console.WriteLine($"Product with ID {product.Id} already exists.");
                return;
            }
            products.Add(product.Id, product);
            Console.WriteLine($"Product '{product.Name}' added successfully.");

        }

        public Product GetProductById(int id)
        {
            if(products.ContainsKey(id))
            {
                return products[id];
            }

            return null;
        }

        public void RemoveProduct(int id)
        {
            if(products.ContainsKey(id))
            {
                products.Remove(id);
                Console.WriteLine($"Product with ID {id} removed successfully.");
            }
            else
            {
                Console.WriteLine($"Product with ID {id} not found.");
            }
        }

        public void PrintAllProducts()
        {
            foreach (var product in products.Values)
            {
                Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Price: {product.Price}, Category: {product.Category}");
            }
        }
    }
}
