using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var items = new Item()
            {
                //Id = 1,
                Name = "Sample Item"
                //Price = 9.99m
            };
            return View(items );
        }
    }
}
