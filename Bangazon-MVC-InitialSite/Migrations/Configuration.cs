namespace Bangazon_MVC_InitialSite.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Bangazon_MVC_InitialSite.DAL.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Bangazon_MVC_InitialSite.DAL.AppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            context.Customers.AddOrUpdate(x => x.CustomerId,
                new Customer() { CustomerId = 1, Name = "Taylor Shuff", StreetAddress = "123 Street", City = "Columbia", State = "TN", Zip = 38401, Phone = "111-123-4567" },
                new Customer() { CustomerId = 2, Name = "Burt McBurterson", StreetAddress = "123 Street", City = "Nashville", State = "TN", Zip = 37206, Phone = "111-123-4567" },
                new Customer() { CustomerId = 3, Name = "Smitty Werbermanjenson", StreetAddress = "1 avenue", City = "Bikini Bottom", State = "Ocean", Zip = 00001, Phone = "111-111-1111" },
                new Customer() { CustomerId = 4, Name = "Lazer Blazer", StreetAddress = "123 Road", City = "Nashville", State = "TN", Zip = 37201, Phone = "111-123-4567" }
            );

            context.Products.AddOrUpdate(x => x.ProductId,
                new Product() { ProductId = 1, Name = "Motor Oil", Price = 2, Description = "Oil for car motor engine alternator capacitor." },
                 new Product() { ProductId = 2, Name = "Motor Oil", Price = 2, Description = "Oil for car motor engine alternator capacitor." },
                  new Product() { ProductId = 3, Name = "Motor Oil", Price = 2, Description = "Oil for car motor engine alternator capacitor." }

                );

            context.ProductTypes.AddOrUpdate(x => x.ProductTypeId,
                new ProductType() { ProductTypeId=1, Type="Auto" },
                new ProductType() { ProductTypeId = 2, Type = "Electronics" },
                new ProductType() { ProductTypeId = 3, Type = "Grocery" }
            );
        }
    }
}
