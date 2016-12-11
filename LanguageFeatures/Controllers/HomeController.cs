using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }
        public ViewResult UseExtension()
        {
            // create and populate ShoppingCart
            ShoppingCart cart = new ShoppingCart
            {
                Products = new List<Product> {
new Product {Name = "Kayak", Price = 275M},
new Product {Name = "Lifejacket", Price = 48.95M},
new Product {Name = "Soccer ball", Price = 19.50M},
new Product {Name = "Corner flag", Price = 34.95M}
}
            };
            // get the total value of the products in the cart
            decimal cartTotal = cart.TotalPrices();
            return View("Result",
            (object)String.Format("Total: {0:c}", cartTotal));
        }

     //   public ViewResult AutoProperty()
      //  {
            // create a new Product object
        //    Product myProduct = new Product();

            //Mixing : )) quite like javascript, because not need to create a new class, but having the new keyword
            // But how can use the Dictionary? type is quite diffirently
           // Dictionary<string, int> myDict = new Dictionary<string, int> {
             //   { "apple", 10 }, { "orange", 20 }, { "plum", 30 }
               // };

            //hakm 
            //String[] stringBig = { "fisrt", "second" };
            //string[] stringSmall = { "fisrt", "second" };
            //List<int> intList = new List<int> { 10, 20, 30 };
            // set the property value
            //myProduct.Name = "Kayak";
            // get the property
            //string productName = myProduct.Name;

            // generate the view
            //return View("Result",
            //(object)String.Format("Product name: {0}", stringSmall[1]));

            // create and populate ShoppingCart
// ...other action methods omitted for brevity...

         

            //HaKM 
            //            return View("Result",
            //           (object)String.Format("Product name: {0}", (object)stringSmall[1]));
      //  }
    }
}
