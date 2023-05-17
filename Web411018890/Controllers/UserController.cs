using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web411018890.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string name,string acc,string pwd)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                ViewBag.NameMsg = "請輸入姓名";
            }
            if (String.IsNullOrWhiteSpace(acc))
            {
                ViewBag.AccMsg = "請輸入帳號";
            }
            if (String.IsNullOrWhiteSpace(pwd))
            {
                ViewBag.PwdMsg = "請輸入密碼";
            }
            if(!(String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(acc) || String.IsNullOrWhiteSpace(pwd)))
            {
                ViewBag.Msg = "註冊成功";
            }
            return View();
        }
    }
}