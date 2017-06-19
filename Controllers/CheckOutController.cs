using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class CheckOutController : Controller
    {
        OnlineShopEntities2 db = new OnlineShopEntities2();
        // GET: CheckOut
        public ActionResult Index()
        {
            ViewBag.PayMethod = new SelectList(db.PaymentTypes, "PayTypeID", "TypeName");
            var data = this.GetDefaultData();
            return View(data);
        }
        //PLACE ORDER--LAST STEP
       

    }
}