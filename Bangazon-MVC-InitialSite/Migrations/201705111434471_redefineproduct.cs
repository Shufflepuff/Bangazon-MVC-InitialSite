namespace Bangazon_MVC_InitialSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class redefineproduct : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Products", "ProductTypeId", "dbo.ProductTypes");
            DropIndex("dbo.Products", new[] { "ProductTypeId" });
            DropIndex("dbo.Products", new[] { "CustomerId" });
            AlterColumn("dbo.Products", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
            CreateIndex("dbo.Products", "CustomerId");
            CreateIndex("dbo.Products", "ProductTypeId");
            AddForeignKey("dbo.Products", "ProductTypeId", "dbo.ProductTypes", "ProductTypeId", cascadeDelete: true);
            AddForeignKey("dbo.Products", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
        }
    }
}
