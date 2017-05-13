namespace Bangazon_MVC_InitialSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Invoices", "paymentId", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "CustomerId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "CustomerId");
            DropColumn("dbo.Invoices", "paymentId");
        }
    }
}
