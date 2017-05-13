namespace Bangazon_MVC_InitialSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateproductmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Invoices", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "ProductType_ProductTypeId", c => c.Int());
            CreateIndex("dbo.InvoiceLines", "InvoiceId");
            CreateIndex("dbo.Invoices", "CustomerId");
            CreateIndex("dbo.Payments", "CustomerId");
            CreateIndex("dbo.Products", "Customer_CustomerId");
            CreateIndex("dbo.Products", "ProductType_ProductTypeId");
            AddForeignKey("dbo.Invoices", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.InvoiceLines", "InvoiceId", "dbo.Invoices", "InvoiceId", cascadeDelete: true);
            AddForeignKey("dbo.Payments", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.Products", "Customer_CustomerId", "dbo.Customers", "CustomerId");
            AddForeignKey("dbo.Products", "ProductType_ProductTypeId", "dbo.ProductTypes", "ProductTypeId");
            DropColumn("dbo.Products", "TypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "TypeId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Products", "ProductType_ProductTypeId", "dbo.ProductTypes");
            DropForeignKey("dbo.Products", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Payments", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.InvoiceLines", "InvoiceId", "dbo.Invoices");
            DropForeignKey("dbo.Invoices", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Products", new[] { "ProductType_ProductTypeId" });
            DropIndex("dbo.Products", new[] { "Customer_CustomerId" });
            DropIndex("dbo.Payments", new[] { "CustomerId" });
            DropIndex("dbo.Invoices", new[] { "CustomerId" });
            DropIndex("dbo.InvoiceLines", new[] { "InvoiceId" });
            DropColumn("dbo.Products", "ProductType_ProductTypeId");
            DropColumn("dbo.Products", "Customer_CustomerId");
            DropColumn("dbo.Invoices", "paymentId");
            DropColumn("dbo.Invoices", "CustomerId");
        }
    }
}
