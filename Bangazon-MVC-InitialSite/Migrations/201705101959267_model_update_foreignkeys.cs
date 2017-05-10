namespace Bangazon_MVC_InitialSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class model_update_foreignkeys : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Invoices", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "ProductTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.InvoiceLines", "InvoiceId");
            CreateIndex("dbo.Invoices", "CustomerId");
            CreateIndex("dbo.Payments", "CustomerId");
            CreateIndex("dbo.Products", "ProductTypeId");
            CreateIndex("dbo.Products", "CustomerId");
            AddForeignKey("dbo.Invoices", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.InvoiceLines", "InvoiceId", "dbo.Invoices", "InvoiceId", cascadeDelete: true);
            AddForeignKey("dbo.Payments", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.Products", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.Products", "ProductTypeId", "dbo.ProductTypes", "ProductTypeId", cascadeDelete: true);
            DropColumn("dbo.Products", "TypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "TypeId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Products", "ProductTypeId", "dbo.ProductTypes");
            DropForeignKey("dbo.Products", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Payments", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.InvoiceLines", "InvoiceId", "dbo.Invoices");
            DropForeignKey("dbo.Invoices", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Products", new[] { "CustomerId" });
            DropIndex("dbo.Products", new[] { "ProductTypeId" });
            DropIndex("dbo.Payments", new[] { "CustomerId" });
            DropIndex("dbo.Invoices", new[] { "CustomerId" });
            DropIndex("dbo.InvoiceLines", new[] { "InvoiceId" });
            DropColumn("dbo.Products", "ProductTypeId");
            DropColumn("dbo.Invoices", "CustomerId");
        }
    }
}
