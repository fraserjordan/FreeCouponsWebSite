namespace Coupons.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImagePathAttribute : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserModels", "BusinessImagePath", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserModels", "BusinessImagePath");
        }
    }
}
