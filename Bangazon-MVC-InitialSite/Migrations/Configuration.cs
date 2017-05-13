namespace Bangazon_MVC_InitialSite.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Bangazon_MVC_InitialSite.Models;

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
                new Customer() { CustomerId=1, Name="Taylor Shuff", StreetAddress="123 Street", City="Columbia", State="TN", Zip=38401, Phone="111-123-4567"},
                new Customer() { CustomerId = 1, Name = "Burt McBurterson", StreetAddress = "123 Street", City = "Nashville", State = "TN", Zip = 37206, Phone = "111-123-4567" },
                new Customer() { CustomerId = 1, Name = "Smitty Werbermanjenson", StreetAddress = "1 avenue", City = "Bikini Bottom", State = "Ocean", Zip = 00001, Phone = "111-111-1111" },
                new Customer() { CustomerId = 1, Name = "Lazer Blazer", StreetAddress = "123 Road", City = "Nashville", State = "TN", Zip = 37201, Phone = "111-123-4567" }
                );
        }
    }
}
