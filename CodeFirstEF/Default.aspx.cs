using CodeFirstEF.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirstEF
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OK_Click(object sender, EventArgs e)
        {
            // f7 to go to code behind
            using (var db = new ContsoDBContext())
            {
                var departments = db.Department.Include(d=>d.Courses).ToList();
                //foreach (var dep in departments)
                //{
                //    Response.Write(dep.Name + "</br>");
                //    foreach (var course in dep.Courses)
                //    {
                //        Response.Write(course.CourseName + "</br>");
                //    }
                //}
            }
        }
    }
}