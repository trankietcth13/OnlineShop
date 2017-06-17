using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Areas.Admin.Models;
using OnlineShop.Common;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {

        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Login (LoginModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var dao = new UserDao();
        //        var result = dao.Login(model.UserName, Encryptor.MD5Hash(model.Password));
        //        if (result == 1)
        //        {
        //            var user = dao.GetById(model.UserName);
        //            var userSession = new UserLogin();
        //            userSession.UserName = user.Username;
        //            userSession.UserID = user.ID;

        //            Session.Add(CommonConstants.USER_SESSION,userSession);
        //            return RedirectToAction("Index", "Home");
        //        }else if(result == 0)
        //        {
        //            ModelState.AddModelError("", "Account not exist.");
        //        }
        //        else if(result == -1)
        //        {
        //            ModelState.AddModelError("", "Account have been locked.");
        //        }
        //        else if (result == -2)
        //        {
        //            ModelState.AddModelError("", "Password wrong.");
        //        }
                
        //        else
        //        {
        //            ModelState.AddModelError("", "Sign in unsuccessfull");
        //        }
        //    }
        //    return View("Index");
          
        //}
    }
}