using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StartedWeb.Models;

namespace StartedWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            //Modelin tipini view de belirtmemiz gerek
            //string[] courses = new[] { "Math", "Bio", "Geo", "Chemisty" };
            //return View(courses);

            //Ürün sınıfına ait bir liste oluşturmak istersek
            //List<Product> products = new List<Product>();
            //Listeyi oluşturup eleman eklemek istersek
            List<Product> products = new List<Product>()
            {
                new Product(){ProductId = 1,ProductName = "Tea",ProductInfo = "Doğuş Kırmızı Meyveler", StockAmount = 1000,IsSale = true},
                new Product() {ProductId = 101,ProductName = "Pantpas 40mg",ProductInfo = "Pantpas 40 mg Enterik Kaplı Tablet",StockAmount = 580,IsSale = true},
                new Product() {ProductId = 703,ProductName = "4Tech V9C Mouse",ProductInfo = "Ultimate Gaming Gear Bloody V9C Mouse",StockAmount = 295,IsSale = true},
                new Product() {ProductId = 407,ProductName = "Lg 6470UK Smart Tv",ProductInfo = "Lg 6470UK Smart Tv 50 Ekran VA Panel",StockAmount = 600,IsSale = true}
            };


            List<Category> categories = new List<Category>()
            {
                new Category(){CategoryId = 1,CategoryName = "Food",CategoryInfo = "Food is any substance consumed to provide nutritional support for an organism. Food is usually of plant or animal origin, and contains essential nutrients, such as carbohydrates, fats, proteins, vitamins, or minerals."},
                new Category(){CategoryId = 2, CategoryName = "Drug", CategoryInfo = "Drug for Medicine"}
            };



            ProductCategoryModel productCategoryModel = new ProductCategoryModel();
            productCategoryModel.Categories = categories;
            productCategoryModel.Products = products;


            //ViewBag sayesinde birden fazla model parametre gönderebiliyoruz view e 
            ViewBag.productCount = products.Count();
            ViewBag.categoriesView = categories;


            return View(products);
        }
    }
}