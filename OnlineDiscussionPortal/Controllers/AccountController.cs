using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineDiscussionPortal.Entity; 

namespace OnlineDiscussionPortal.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult SignIn()
        {
            return View();
        }
        
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(Account account)
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Account account)
        {
            return View();
        }

    }
}