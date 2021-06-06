using QLHieuThuoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace QLHieuThuoc.Controllers
{
    public class AccountsController : Controller
    { 
        [HttpPost]
        public ActionResult Login(AccountModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username.Equals("Admin") && model.Password.Equals("123456"))
                {
                    FormsAuthentication.SetAuthCookie(model.Username, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.invalidData = "Nhập username = Admin và pass = 123456 ";
                }
            }
            return View(model);
        }
    }
}
