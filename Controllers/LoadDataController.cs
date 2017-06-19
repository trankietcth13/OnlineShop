using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public static class LoadDataController 
    {
        static OnlineShopEntities2 db = new OnlineShopEntities2(); 
        // GET: LoadData
        
        public static List<OrderDetail> GetDefaultData(this ControllerBase controller)
        {
            if(TempShpData.items == null)
            {
                TempShpData.items = new List<OrderDetail>();
            }
            var data = TempShpData.items.ToList();

            controller.ViewBag.cartBox = data.Count == 0 ? null : data;
            controller.ViewBag.NoOfItem = data.Count();
            int? SubToTal = Convert.ToInt32(data.Sum(x => x.TotalAmount));
            controller.ViewBag.ToTal = SubToTal;

            int Discount = 0;
            controller.ViewBag.SubTotal = SubToTal;
            controller.ViewBag.Discount = Discount;
            controller.ViewBag.TotalAmount = SubToTal - Discount;

            controller.ViewBag.WlItemsNo = db.Wishlists.Where(x => x.CustomerID == TempShpData.UserID).ToList().Count();
            return data;

        }
    }
}