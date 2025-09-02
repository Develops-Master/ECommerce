namespace ECommerce.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ECommerce.Web.Models.ECommerceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ECommerce.Web.Models.ECommerceContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ECommerce.Web.Models.ECommerceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
