namespace CodeFirstEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedepartment : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Departments", "CreatedTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "CreatedTime", c => c.DateTime(nullable: false));
        }
    }
}
