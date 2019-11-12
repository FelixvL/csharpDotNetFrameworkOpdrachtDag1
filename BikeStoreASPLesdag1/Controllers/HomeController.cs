using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BikeStoreASPLesdag1.Models;
using BikeStoreASPLesdag1.Repositories;

namespace BikeStoreASPLesdag1.Controllers
{
    public class HomeController : Controller
    {
        private ProductRepository productRepo = new ProductRepository();
        public ActionResult Index()
        {
            List<ProductModel> producten = productRepo.getAlleProducten();
            return View(producten);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ShowStoresForProduct(int productId) {
            System.Console.WriteLine("Hoi"+productId);
            return View("StoreDetails",new { pi = 5});
        }
    }
}