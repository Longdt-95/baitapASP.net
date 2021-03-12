using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise.Controllers
{
    public class LoginController : Controller
    {
        private const string userName = "admin";
        private const string password = "admin";
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult CheckLogin(string userName1, string password1)
        {
            if (userName1.Equals(userName) && password1.Equals(password))
            {
                return RedirectToAction("Index", "Home");
            }else
            {
                if (userName1.Equals(userName))
                {
                    TempData["message"] = "mật khẩu không chính xác";
                }else if (password1.Equals(password))
                {
                    TempData["message"] = "tên đăng nhập không chính xác";
                }else
                {
                    TempData["message"] = "tên đăng nhập và mật khẩu không chính xác";
                }
                return RedirectToAction("Login");
            }
        }
    }

    
}