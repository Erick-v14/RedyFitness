using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using RedyFitness.Data;
using RedyFitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace RedyFitness.Controllers
{
    public class UsersController : Controller
    {
        // GET: Customer
        public ActionResult CreateUser()
        {
            return View();
        }

        private UserManager UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<UserManager>();
            }
        }

      
        [HttpPost]

        public async Task<ActionResult> CreateUser(CrateCustomerModel model)
        {
            IdentityResult result = null;
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    LoginName = model.LoginName,
                    Password = model.Password,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    DateofBirth = model.DateofBirth,
                 
                    Weight = model.Weight
                };
               
               result = await UserManager.CreateAsync(user, model.Password);
           
               
                if (result.Succeeded)
                {
                    ViewBag.message = "Your Account has been created!";
                    return View();
                }
                else
                {
                    ViewBag.msg = "An error has occured, please re-enter your information to create a new account";
                    return View();
                }
            }
            return View();

    }
              [HttpPost]
        public ActionResult CreatUser(CrateCustomerModel model)
        {
            return View();
        }
       
    }
}