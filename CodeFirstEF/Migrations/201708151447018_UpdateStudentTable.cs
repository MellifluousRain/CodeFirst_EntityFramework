namespace CodeFirstEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStudentTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Ssn", c => c.String());
            AddColumn("dbo.Students", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "PhoneNumber");
            DropColumn("dbo.Students", "Ssn");
        }
    }
}
