namespace Coupons.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPictureAttirubute : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserModels", "DisplayPicture", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserModels", "DisplayPicture");
        }
    }
}
