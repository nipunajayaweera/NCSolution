namespace NCSolution.Migrations.Migrations
{
    using NCSolution.DomainModel.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NCSolution.DataAccessLayer.NCSolutionDbContext>
    {

        LoginUser kumaraLogin;
        LoginUser tokeLogin;
        Exam examTwo;
        Exam examOne;

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NCSolution.DataAccessLayer.NCSolutionDbContext context)
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




          






        }
    }
}
