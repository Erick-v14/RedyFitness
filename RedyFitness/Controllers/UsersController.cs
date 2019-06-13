using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using RedyFitness.Data;
using RedyFitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateUser(CrateCustomerModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.LoginName,
                    PasswordHash = model.Password,
                    SecurityStamp = model.ConfirmPassword,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    DateofBirth = model.DateofBirth,

                };
                var result = await UserManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {


                    ViewBag.message = "Your account has been created!";
                    return RedirectToAction("Login", "Users");
                }
                
                else
                {
                    ViewBag.msg = "An error has occured, please re-enter your information to create a new account";
                    return View();
                }
            }

            return View(model);
        }
        //Check to see if Email is unique when creating account
        //TODO: should give viewbag.message 2--doesnt let user register with  
      [HttpPost]      
       public JsonResult doesEmailExist(string Email)
        {
            var email = System.Web.Security.Membership.GetUser(Email);
            ViewBag.message2 = "This email address is already registered";
           
         return Json(email == null);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await UserManager.FindByNameAsync(model.UserName);
                if (user!=null)
                {
                    ApplicationUser c = await UserManager.FindAsync(user.UserName,model.Password);
                    if(c !=null)
                    {
                        ClaimsIdentity ident = await UserManager.CreateIdentityAsync(c, DefaultAuthenticationTypes.ApplicationCookie);
                        AuthManager.SignOut();
                        AuthManager.SignIn(new AuthenticationProperties
                        {
                            IsPersistent = false
                        }, ident);

                        return RedirectToAction("Index","Home");
                    }
                    else
                    {
                        ViewBag.msg = "Incorrect Password";
                        return View();
                    }
                }
                else
                {
                    ViewBag.msg = "This User Name is not registered";
                    return View();
                }
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Logout()
        {
            return View();
        }


        private IAuthenticationManager AuthManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
      
    }
}