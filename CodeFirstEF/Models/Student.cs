using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstEF.Models
{
    public class Student
    {
        //public int id { get; set; }
        //[Key] // [] means attribute
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public string Ssn { get; set; }
        public string PhoneNumber { get; set; }
    }
}