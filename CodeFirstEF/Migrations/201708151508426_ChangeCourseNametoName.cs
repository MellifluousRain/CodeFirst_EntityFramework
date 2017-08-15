namespace CodeFirstEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCourseNametoName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Courses", name: "CourseName", newName: "Name");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Courses", name: "Name", newName: "CourseName");
        }
    }
}
