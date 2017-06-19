using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        OnlineShopEntities2 db = new OnlineShopEntities2();

        // GET: Home
        public ActionResult Index() {
            ViewBag.MenProduct = db.Products.Where(x => x.Category.Name.Equals("Men")).ToList();
            ViewBag.WomenProduct = db.Products.Where(x => x.Category.Name.Equals("Women")).ToList();
            ViewBag.BoysProduct = db.Products.Where(x => x.Category.Name.Equals("Boys")).ToList();
            ViewBag.GirlsProduct = db.Products.Where(x => x.Category.Name.Equals("Girls")).ToList();      
            this.GetDefaultData();
            return View();
        }


        [ChildActionOnly]
        public ActionResult MainMenu() {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult TopMenu()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult Footer()
        {
            return PartialView();
        }

        public ActionResult Category()
        {
            var model = db.Categories;
            return PartialView("_Category", model);
        }
            
    }
}