using StateManagementLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateManagementLab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Result(Registration r)
        {

            if (Session["one"] == null)
            {
                Session["one"] = "active";
                Session["Name"] = r.userName;
                Session["Email"] = r.email;
                Session["Age"] = r.age;
            }
           
           
            return View();
        }

        public ActionResult Logout()
        {
            ViewBag.name = Session["Name"];
            Session["one"] = null;

            return View();
        }
    }
}