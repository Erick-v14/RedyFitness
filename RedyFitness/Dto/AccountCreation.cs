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
        public string ConfirmPass { get; set; }
       
        public string UserEmail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char UserGender { get; set; }
        public int UserWeight { get; set; }
        
        public AccountCreation NewUser()
        {
            return new AccountCreation()
            {
                UserName = UserName,
                UserPass = UserPass,
                UserEmail = UserEmail,
                DateOfBirth = DateOfBirth,
                UserGender = UserGender,
                UserWeight = UserWeight,
            };
                                         
        }

    }
}