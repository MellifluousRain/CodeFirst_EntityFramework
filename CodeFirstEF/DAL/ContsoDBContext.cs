using CodeFirstEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstEF.DAL
{
    public class ContsoDBContext : DbContext
    {
        public ContsoDBContext():base("name=ContsoCF")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Course> Course { get; set; }
    }
}




