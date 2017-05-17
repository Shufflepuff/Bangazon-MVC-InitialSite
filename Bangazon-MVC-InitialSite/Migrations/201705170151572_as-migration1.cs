namespace Bangazon_MVC_InitialSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asmigration1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Invoices", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Invoices", new[] { "CustomerId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Invoices", "CustomerId");
            AddForeignKey("dbo.Invoices", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
        }
    }
}
