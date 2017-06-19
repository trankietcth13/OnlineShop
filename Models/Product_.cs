using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShop.Models;

namespace OnlineShop.Models
{
   
    public class Product_
    {
        OnlineShopEntities2 db = null;
        public Product_()
        {
            db = new OnlineShopEntities2();
        }
        public List<Product> ListNewProduct()
        {
            return db.Products.OrderByDescending(x => x.CreatedDate).ToList();
        }
    }
}