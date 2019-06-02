using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using RedyFitness.Models;
using RedyFitness.Data;
using System.Data.Entity;

namespace RedyFitness.Data
{
    public class Context : IdentityDbContext<ApplicationUser>
    {
        public Context() : base ("ConString")
        {

        }

        public static Context Create()
        {
            return new Context();
        }

        public DbSet<User> users { get; set; }

    }
} 