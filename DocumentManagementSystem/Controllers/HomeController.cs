using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DocumentManagementSystem.Models;


namespace DocumentManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private DbOperationDataContext _context;
        public HomeController()
        {
            _context = new DbOperationDataContext();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login loginObject)
        {
            var loginDetails = _context.tbl_Logins.Where(m => m.UserName == loginObject.UserName && m.Password == loginObject.Password).FirstOrDefault();

        if (loginDetails != null)
        {
                var name = loginObject.UserName;
                Session["ID"] = name;
                if (loginDetails.Role == "admin")
                {
                    TempData["name"] = name;
                    return RedirectToAction("Login", "Admin");
                }
                else  
                {
                    TempData["name"] = name;
                    return RedirectToAction("Login", "User");
                }


        }
        else
        {
            return View();
        }
          
    }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

    
