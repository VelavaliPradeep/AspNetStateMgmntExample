using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateMgmtExample.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string userTxt, string userPass)
        {
            if (userTxt == "pradeep" && userPass == "12345")
            {
                //HttpCookie kt1 = new HttpCookie("username", userTxt);
                //Response.Cookies.Add(kt1);

                //Response.Cookies["password"].Value = userPass;

                Session["username"] = userTxt;
                Session["password"] = userPass;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }
    }
}