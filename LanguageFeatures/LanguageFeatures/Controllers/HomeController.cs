using LanguageFeatures.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Navigate to a URL ";
        }

        public ViewResult AutoProperty()
        {
            Product myProduct = new Product();
            myProduct.Name = "kayak";
            string productName = myProduct.Name;
            return View("Result", (object) String.Format("Product Name,:{0}", productName));
        }

        public ViewResult CreateProduct()
        {
            Product myProduct = new Product
            {

                ProductID = 100,
                Name = "kayak",
                Description = "A boat for one person",
                Price = 274M,
                Category = "Watersports"
            };
            return View("Result", (object) String.Format("Product Category,:{0}", myProduct.Category));

        }

        public ViewResult CreateCollection()
        {
            string[] stringArray = {"apple", "orange", "plum"};

            List<int> intList = new List<int> {10, 20, 30, 40};

            Dictionary<string, int> myDict = new Dictionary<string, int>
            {
                {"apple", 10},
                {"orange", 20},
                {"plum", 30}
            };

            return View("Result", (object) stringArray[1]);
        }

        public ViewResult UseExtension()
        {
            ShoppingCart cart = new ShoppingCart
            {
                Products = new List<Product>
                {
                    new Product {Name = "kayak", Price = 120m},
                    new Product {Name = "lifejack", Price = 10m},
                    new Product {Name = "Knife", Price = 12m},
                    new Product {Name = "Fishing pole", Price = 14m},
                    new Product {Name = "Flag", Price = 23m}
                }
            };
            decimal cartTotal = cart.TotalPrices();
            return View("Result", (object) String.Format("Total :{0:C}", cartTotal));

        }
    }
}
    

