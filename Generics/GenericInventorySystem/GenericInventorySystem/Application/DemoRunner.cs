using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericInventorySystem.Models;
using GenericInventorySystem.Services;
using GenericInventorySystem.CollectionsDemo;


namespace GenericInventorySystem.Application
{
    internal class DemoRunner
    {
        public void Run()
        {
            RunInventoryDemo();
            RunListDemo();
            RunDictionaryDemo();
            RunHashSetDemo();


        }

        private void RunInventoryDemo()
        {
            InventoryService inventoryService = new InventoryService();

            inventoryService.AddProduct(new Product { Id = 1, Name = "Laptop", Price = "1200", Category = "Electronics" });
            inventoryService.AddProduct(new Product { Id = 2, Name = "Phone", Price = "800", Category = "Electronics" });

            var products = inventoryService.GetAllProducts();

            Console.WriteLine("Inventory Service Demo:");

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id} - {product.Name} - {product.Price}");
            }
        }

        private void RunListDemo()
        {
            ListManager listManager = new ListManager();
            listManager.AddProduct(new Product { Id = 1, Name = "Laptop", Price = "1200", Category = "Electronics" });
            listManager.AddProduct(new Product { Id = 2, Name = "Phone", Price = "800", Category = "Electronics" });
            listManager.AddProduct(new Product { Id = 3, Name = "Headphones", Price = "200", Category = "Accessories" });
            Console.WriteLine("\nList Manager Demo:");
            listManager.PrintProducts();
        }

        private void RunDictionaryDemo()
        {
            DictionaryManager dictionaryManager = new DictionaryManager();
            dictionaryManager.AddProduct(new Product { Id = 1, Name = "Laptop", Price = "1200", Category = "Electronics" });
            dictionaryManager.AddProduct(new Product { Id = 2, Name = "Phone", Price = "800", Category = "Electronics" });
            dictionaryManager.AddProduct(new Product { Id = 3, Name = "Headphones", Price = "200", Category = "Accessories" });
            Console.WriteLine("\nDictionary Manager Demo:");
            dictionaryManager.PrintAllProducts();
        }

        private void RunHashSetDemo()
        {
            HashSetmanager hashSetManager = new HashSetmanager();
            hashSetManager.AddCategory("Electronics");
            hashSetManager.AddCategory("Accessories");
            hashSetManager.AddCategory("Clothing");
            hashSetManager.AddCategory("Electronics"); // Duplicate category
            Console.WriteLine("\nHashSet Manager Demo:");
            hashSetManager.PrintAllCategories();
        }
    }
}
