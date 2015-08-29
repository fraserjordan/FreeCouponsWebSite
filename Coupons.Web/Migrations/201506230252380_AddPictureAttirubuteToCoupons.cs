namespace Coupons.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPictureAttirubuteToCoupons : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserModels", "BusinessImagePath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserModels", "BusinessImagePath", c => c.String(nullable: false));
        }
    }
}
