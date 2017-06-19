using System.Linq;
using System.Web.Mvc;
using OnlineShop.Models;
namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        OnlineShopEntities2 db = new OnlineShopEntities2();
       
        // GET: Product
        public ActionResult Detail()
        {         
            return View("Detail");
        }

        
        public ActionResult Men(int ? subCatId)
        {          
            ViewBag.Categories = db.Categories.Select(x => x.Name).ToList();

            var product_ = new Product_();
            ViewBag.ListNewProduct = product_.ListNewProduct(3);

            var prod = db.Products.Where(y => y.SubcategoryID == subCatId).ToList();                    
            return View(prod);
        }

        public ActionResult Women()
        {
            return View("Women");
        }

        public ActionResult Boys()
        {

            return View("Boys");
        }

        public ActionResult Girls()
        {
            return View("Girls");
        }

    }
}