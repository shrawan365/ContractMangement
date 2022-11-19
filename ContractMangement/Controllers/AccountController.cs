using ContractMangement.Models.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContractMangement.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel login)
        {
            if(login.Password =="admin" && login.Username=="admin" ) {
                return RedirectToAction("Index","Home");
            }
            else {
                login.Username = "";
                ViewBag.error = "Incorrect Username or Password";
                return View(login);
            }
        }
        public ActionResult Singup()
        {
            return View();
        }
        public ActionResult AccountCreate()
        {
            return View();
        }
    }
}