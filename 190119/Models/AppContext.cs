using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace _190119.Models
{
    public class AppContext:DbContext
    {
        public AppContext() : base("AppContext")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }

    }
}