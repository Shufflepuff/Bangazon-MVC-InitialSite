namespace Bangazon_MVC_InitialSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class databasefix : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        StreetAddress = c.String(nullable: false),
                        City = c.String(nullable: false),
                        State = c.String(nullable: false),
                        Zip = c.Int(nullable: false),
                        Phone = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.InvoiceLines",
                c => new
                    {
                        InvoiceLineId = c.Int(nullable: false, identity: true),
                        InvoiceId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceLineId)
                .ForeignKey("dbo.Invoices", t => t.InvoiceId, cascadeDelete: true)
                .Index(t => t.InvoiceId);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Quantity = c.Int(nullable: false),
                        paymentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        AccountNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(nullable: false),
                        Customer_CustomerId = c.Int(),
                        ProductType_ProductTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .ForeignKey("dbo.ProductTypes", t => t.ProductType_ProductTypeId)
                .Index(t => t.Customer_CustomerId)
                .Index(t => t.ProductType_ProductTypeId);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        ProductTypeId = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProductTypeId);
            
        }
        
        public override void Down()
        {
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
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
            DropTable("dbo.Payments");
            DropTable("dbo.Invoices");
            DropTable("dbo.InvoiceLines");
            DropTable("dbo.Customers");
        }
    }
}
