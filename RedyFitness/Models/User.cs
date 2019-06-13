using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RedyFitness.Models
{
    public class User :ApplicationUser
    {
        public string LoginName { get; set; }

        public string ConfirmPassword { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateofBirth { get; set; }

        

        public int Weight { get; set; }
    }

    public class CrateCustomerModel
    {
        [Required]
        [Display(Name ="User Name")]
         
        public string LoginName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        
        [StringLength(100, ErrorMessage ="The {0} must be at least {2} characters long.",MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare ("Password", ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.EmailAddress,ErrorMessage ="Please enter a valid email")]
        public string Email { get; set; }

        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date,ErrorMessage="Please enter a valid date")]
        [Display(Name ="Date of Birth")]
        public DateTime DateofBirth { get; set; }

        [Required]
        public int Weight { get; set; }
    }
        public class LoginModel
    {
        
        [Required(ErrorMessage ="Please enter your User Name")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Please enter your Password")]
        public string Password { get; set; }
    }
}