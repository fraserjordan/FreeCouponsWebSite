namespace Coupons.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPictureAttirubuteToCoupon : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CouponModels", "DisplayPicture", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CouponModels", "DisplayPicture");
        }
    }
}
