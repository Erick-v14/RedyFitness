using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RedyFitness.Dto
{
    public class Login
    {
        [Required (ErrorMessage ="Please Enter your User Name")]
        public string userName { get; set; }

        [Required (ErrorMessage ="Please Enter your password")]
        public string userPassword { get; set; }
    }
}