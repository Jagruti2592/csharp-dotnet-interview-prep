// See https://aka.ms/new-console-template for more information
using GenericInventorySystem.Models;
using GenericInventorySystem.Repository;
using GenericInventorySystem.Services;
using GenericInventorySystem.CollectionsDemo;
using GenericInventorySystem.Application;

Console.WriteLine("Hello, World!");
//GenericRepository<Product> productRepository = new GenericRepository<Product>();

//productRepository.Add( new Product {Id = 1, Name="Laptop", Price ="1200",Category = "Electronics" });
//productRepository.Add(new Product { Id = 2, Name = "Phone", Price = "800", Category = "Electronics" });

//productRepository.Add(new Product { Id = 3, Name = "Headphones", Price = "200", Category = "Accessories" });

//Console.WriteLine("Product added to the repository.");
//var products = productRepository.GetAll();
//foreach (var product in products) {
//    Console.WriteLine($"{product.Id} - {product.Name}-{product.Price} -{product.Category}");
//}

//var productById = productRepository.getById(1);
//Console.WriteLine($"{productById.Id} - {productById.Name} - {productById.Price} - {productById.Category}");

//productRepository.Update(new Product { Id = 1, Name = "Gaming Laptop", Price = "1500", Category = "Electronics" });

//var updatedProducts = productRepository.GetAll();
//foreach (var product in updatedProducts)
//{
//    Console.WriteLine($"{product.Id} - {product.Name} - {product.Price} - {product.Category}");
//}

//productRepository.Remove(2);

//var remainingProducts = productRepository.GetAll();
//foreach (var product in remainingProducts)
//{
//    Console.WriteLine($"{product.Id} - {product.Name} - {product.Price} - {product.Category}");
//}

//Accessing data using Service layer
//InventoryService inventoryService = new InventoryService();

//inventoryService.AddProduct(new Product {Id =1, Name ="Laptop",Price = "1200",  Category = "Electronics" });
//inventoryService.AddProduct(new Product { Id = 2, Name = "Phone", Price = "800", Category = "Electronics" });


//var allProducts = inventoryService.GetAllProducts();
//Console.WriteLine("Products in Inventory:");
//foreach (var product in allProducts)
//{
//    Console.WriteLine($"{product.Id} -{product.Name} - {product.Price} - {product.Category}  ");
//}

//ListManager listManager = new ListManager();

//listManager.AddProduct(new Product { Id = 1, Name = "Laptop", Price = "1200", Category = "Electronics" });
//listManager.AddProduct(new Product { Id = 2, Name = "Phone", Price = "800", Category = "Electronics" });
//listManager.AddProduct(new Product { Id = 3, Name = "Headphones", Price = "200", Category = "Accessories" });
//listManager.PrintProducts();

//DictionaryManager dictionaryManager = new DictionaryManager();

//dictionaryManager.AddProduct(new Product { Id = 1, Name = "Laptop", Price = "1200" });
//dictionaryManager.AddProduct(new Product { Id = 2, Name = "Phone", Price = "800" });
//dictionaryManager.AddProduct(new Product { Id = 3, Name = "Tablet", Price = "600" });

//Console.WriteLine("Dictionary Products:");
//dictionaryManager.PrintAllProducts();


//HashSetmanager hashSetManager = new HashSetmanager();

//hashSetManager.AddCategory("Electronics");
//hashSetManager.AddCategory("Accessories");
//hashSetManager.AddCategory("Electronics"); // duplicate

//hashSetManager.PrintAllCategories();

DemoRunner demoRunner = new DemoRunner();
demoRunner.Run();



