using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericInventorySystem.Models;

namespace GenericInventorySystem.CollectionsDemo
{
    internal class ListManager
    {
        
            private List<Product> products;

            public ListManager()
            {
                products = new List<Product>();
            }

        public void AddProduct(Product product)
            {
                products.Add(product);
                Console.WriteLine($"Product added: {product.Name}");
        }

        public void PrintProducts() { 
        
        foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
            }

        }

        public void RemoveProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine($"Product removed: {product.Name}");
            }
            else
            {
                Console.WriteLine($"Product with ID {id} not found.");
            }
        }

        public Product FindProduct(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public void SortProductByPrice() {

            products.Sort((a,b) => a.Price.CompareTo(b.Price));
        
        }

    }
    
}
