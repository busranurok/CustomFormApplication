namespace VaktiHazar.CustomFormApplication.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<VaktiHazar.CustomFormApplication.DataAccess.Concrete.EntityFramework.CustomFormApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VaktiHazar.CustomFormApplication.DataAccess.Concrete.EntityFramework.CustomFormApplicationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
