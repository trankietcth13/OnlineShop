using Model.cs.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        OnlineShopDbContext db = new OnlineShopDbContext();

        // GET: Home
        public ActionResult Index() {
            ViewBag.MenProduct = db.Products.Where(x => x.Category.Name.Equals("Men")).ToList();
            ViewBag.WomenProduct = db.Products.Where(x => x.Category.Name.Equals("Women")).ToList();
            ViewBag.BoysProduct = db.Products.Where(x => x.Category.Name.Equals("Boys")).ToList();
            ViewBag.GirlsProduct = db.Products.Where(x => x.Category.Name.Equals("Girls")).ToList();
            ViewBag.Slider = db.genMainSliders.ToList();
            ViewBag.PromoRight = db.genPromoRights.ToList();
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