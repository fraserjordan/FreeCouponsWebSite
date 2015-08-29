namespace Coupons.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailAttribute : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserModels", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserModels", "Email");
        }
    }
}
