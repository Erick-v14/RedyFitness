using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedyFitness.Dto
{
    public class AccountCreation
    {
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}