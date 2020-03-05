using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineDiscussionPortal.Context;
using OnlineDiscussionPortal.Entity;
using OnlineDiscussionPortal.Repository;
namespace OnlineDiscussionPortal.Controllers
{
    public class AccountController : Controller
    {
        AccountDbContext accountDb = new AccountDbContext();
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
            try
            {
                accountDb.accounts.Add(account);
                accountDb.SaveChanges();
                return RedirectToAction("PersonalDetails");
            }
            catch
            {
                return View();

            }
          
        }
        [ActionName("PersonalDetails")]
        public ActionResult Display()
        {
            IEnumerable<Account> accounts = userRepository.GetUserDetail();
            return View("Display",accounts);
        }
        public ActionResult Edit()
        {
            return View();
        }

        //[HttpPost]
        //[ActionName("Edit")]
        //public ActionResult Edit_Post([Bind(Include = "UserName, Password, Name, Address")] Account account)
        //{
        //    account.MailId = userRepository.accountList.Find(name => name.UserName == account.UserName).MailId;

        //    if (ModelState.IsValid)
        //    {
        //        userRepository.UpdateDetail(account);
        //        return RedirectToAction("PersonalDetails");
        //    }
        //    return View(account);
        //}


        //[HttpPost]
        //[ActionName("Edit")]
        //public ActionResult Edit_Post([Bind(Exclude = "UserName,Password")] Account account)
        //{
        //    account.UserName = userRepository.GetUserDetail().Single(x => x.MailId == account.MailId).UserName;

        //    if (ModelState.IsValid)
        //    {
        //        userRepository.UpdateDetail(account);
        //        return RedirectToAction("PersonalDetails");
        //    }
        //    return View(account);
        //}

        public ActionResult DisplayDB()
        {

            return View(accountDb.accounts.ToList());
        }

    }
}
