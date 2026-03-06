using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInventorySystem.CollectionsDemo
{
    internal class HashSetmanager
    {
        private HashSet<string> categories;

        public HashSetmanager() { 
        
          categories = new HashSet<string>();
        }

        public void AddCategory(string category)
        {
            if (categories.Add(category))
            {
                Console.WriteLine($"Category '{category}' added successfully.");
            }
            else
            {
                Console.WriteLine($"Category '{category}' already exists.");
            }
        }

        public void RemoveCategory(string category)
        {
            if (categories.Remove(category))
            {
                Console.WriteLine($"Category '{category}' removed successfully.");
            }
            else
            {
                Console.WriteLine($"Category '{category}' not found.");
            }
        }

        public bool ContainsCategory(string category)
        {
            return categories.Contains(category);
        }

        public void PrintAllCategories()
        {
            Console.WriteLine("Categories:");
            foreach (var category in categories)
            {
                Console.WriteLine($"- {category}");
            }
        }
    }
}
