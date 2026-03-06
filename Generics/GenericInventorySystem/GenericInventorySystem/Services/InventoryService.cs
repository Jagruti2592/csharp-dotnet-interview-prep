using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericInventorySystem.Models;
using GenericInventorySystem.Repository;

namespace GenericInventorySystem.Services
{
    internal class InventoryService
    {
        private GenericRepository<Product> productRepository;
        private GenericRepository<Customer> customerRepository;
        private GenericRepository<Order> orderRepository;


        public InventoryService()
        {
            productRepository = new GenericRepository<Product>();
            customerRepository = new GenericRepository<Customer>();
            orderRepository = new GenericRepository<Order>();
        }

        public void AddProduct(Product product) { 
             productRepository.Add(product);
        }

        public List<Product> GetAllProducts() { 
             return productRepository.GetAll();
        }

        public Product GetProductById(int id) { 
             return productRepository.getById(id);
        }

        public void RemoveProduct(int id)
        {
            productRepository.Remove(
                id);
        }


    }
}
