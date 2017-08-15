using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstEF.Models
{
    public class Department
    {
        public int id { get; set; }
        public String Name { get; set; }
        public Decimal Budget { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}