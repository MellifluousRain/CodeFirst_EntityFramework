using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstEF.Models
{
    public class Course
    {
        public int id { get; set; }
        [StringLength(50)] //attribute // ctrl+.
        [Column("Name")]
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public int DepartmentId { get; set; } // foreignkey
        public Department department { get; set; } // department according to foreignkey automatically(convention over configuration)

        //[NotMapped]
        //public int Age { get; set; } // Don't create this column
    }
}