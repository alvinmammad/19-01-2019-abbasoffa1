namespace _190119.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentAndGroupAnnotations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groups", "Cost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Students", "Birthday", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Groups", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "Surname", c => c.String(maxLength: 50));
            AlterColumn("dbo.Students", "Phone", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Phone", c => c.String());
            AlterColumn("dbo.Students", "Surname", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
            AlterColumn("dbo.Groups", "Name", c => c.String());
            DropColumn("dbo.Students", "Birthday");
            DropColumn("dbo.Groups", "Cost");
        }
    }
}
