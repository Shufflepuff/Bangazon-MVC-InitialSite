namespace Bangazon_MVC_InitialSite.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Bangazon_MVC_InitialSite.Models;
    using Microsoft.AspNet.Identity;
    using DAL;
    using System.Threading.Tasks;

    internal sealed class Configuration : DbMigrationsConfiguration<Bangazon_MVC_InitialSite.DAL.AppContext>
    {
        private AppContext _context;
        private UserManager<Customer> _userManager;

        public Configuration(AppContext context, UserManager<Customer> UserManager)
        {
            AutomaticMigrationsEnabled = false;
            _context = context;
            _userManager = UserManager;
        }

        protected override void Seed(AppContext context)
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
            

            var user = new Customer()
            {
                UserName = "taylor",
                Email="taylor@bangazon.com"
            };

            _userManager.Create(user, "P@ssw0rd!");


            if(!_context.Products.Any())
            {
                var seedProduct = new Product()
                {
                    Name="productOne",
                    Price=3,
                    ProductTypeId=1,
                    Username="taylor"
                };
            }

    }
    }
}
