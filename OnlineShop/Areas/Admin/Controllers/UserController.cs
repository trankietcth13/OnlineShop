using Model.cs.EF;
using OnlineShop.Common;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
namespace OnlineShop.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {

        //    // GET: Admin/User
        //    public ActionResult Index(string searchString,int page = 1,  int pageSize = 10)
        //    {
        //        var dao = new UserDao();
        //        var model = dao.ListAllPaging(searchString, page, pageSize);
        //        ViewBag.SearchString = searchString;
        //        return View(model);
        //    }

        //    [HttpGet]
        //    public ActionResult Create()
        //    {
        //        return View();
        //    }

        //    public ActionResult Edit(int id)
        //    {
        //        var user = new UserDao().ViewDetail(id);
        //        return View(user);
        //    }

        //    [HttpPost]
        //    public ActionResult Create(User1 user)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            var dao = new UserDao();

        //            var encryptedMd5Pas = Encryptor.MD5Hash(user.Password);
        //            user.Password = encryptedMd5Pas;
        //            long id = dao.Insert(user);
        //            if (id > 0)
        //            {

        //                SetAlert("User add successfully", "success");
        //                return RedirectToAction("Index", "User");
        //            }
        //            else
        //            {
        //                ModelState.AddModelError("", "User add unsuccessfully.");
        //            }
        //        }
        //        return View("Index");

        //    }

        //    [HttpPost]
        //    public ActionResult Edit(User1 user)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            var dao = new UserDao();
        //            if (!string.IsNullOrEmpty(user.Password))
        //            {
        //                var encryptedMd5Pas = Encryptor.MD5Hash(user.Password);
        //                user.Password = encryptedMd5Pas;
        //            }


        //            var result = dao.Update(user);

        //            if (result)
        //            {
        //                SetAlert("User edit successfully", "success");
        //                return RedirectToAction("Index", "User");
        //            }
        //            else
        //            {
        //                ModelState.AddModelError("", "User update unsuccessfully.");
        //            }
        //        }
        //        return View("Index");

        //    }

        //    public ActionResult Delete(int id)
        //    {
        //        new UserDao().Delete(id);
        //        return RedirectToAction("Index");
        //    }

        //    [HttpPost]
        //    public JsonResult ChangeStatus(long id)
        //    {
        //        var result = new UserDao().ChangeStatus(id);
        //        return Json(new
        //        {
        //            status = result
        //        });
        //    }
        //}
    }
}