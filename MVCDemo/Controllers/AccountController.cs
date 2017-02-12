using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.LoginState = "登录前。。。";
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            // 获取表单数据
            var email = fc["inputEmail3"];
            var password = fc["inputPassword3"];

            // 进行下一步处理，这里先改一下名字
            ViewBag.LoginState = email + "登陆后。。。";
            return View();
        }

        [HttpPost]
        public ActionResult Register()
        {
            return View();
        }
    }
}