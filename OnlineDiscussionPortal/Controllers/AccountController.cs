using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineDiscussionPortal.Entity;
using OnlineDiscussionPortal.Repository;
namespace OnlineDiscussionPortal.Controllers
{
    public class AccountController : Controller
    {
        UserRepository userRepository;
        public AccountController()
        {
            userRepository = new UserRepository();
        }
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
        [ActionName("PersonalDetails")]
        public ActionResult Display()
        {
            IEnumerable<Account> accounts = userRepository.GetUserDetail();
            return View("Display",accounts);
        }
    }
}
