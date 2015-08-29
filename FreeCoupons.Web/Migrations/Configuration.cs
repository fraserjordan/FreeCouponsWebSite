namespace FreeCoupons.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using FreeCoupons.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<FreeCoupons.Web.Infrastructure.UserDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FreeCoupons.Web.Infrastructure.UserDb context)
        {
            context.Users.AddOrUpdate(m => m.Name,
                new User() { Name = "fraser jordan", Email = "fraser.jord@gmail.com", Password = "letmein" }
                );
        }
    }
}
