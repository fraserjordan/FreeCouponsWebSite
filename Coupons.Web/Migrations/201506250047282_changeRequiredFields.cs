namespace Coupons.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeRequiredFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserModels", "UserName", c => c.String());
            AlterColumn("dbo.UserModels", "BusinessName", c => c.String());
            AlterColumn("dbo.UserModels", "Email", c => c.String());
            AlterColumn("dbo.UserModels", "DisplayPicture", c => c.Binary());
            AlterColumn("dbo.UserModels", "Address", c => c.String());
            AlterColumn("dbo.UserModels", "Password", c => c.String(maxLength: 100));
            AlterColumn("dbo.UserModels", "ConfirmPassword", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserModels", "ConfirmPassword", c => c.String(nullable: false));
            AlterColumn("dbo.UserModels", "Password", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.UserModels", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.UserModels", "DisplayPicture", c => c.Binary(nullable: false));
            AlterColumn("dbo.UserModels", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.UserModels", "BusinessName", c => c.String(nullable: false));
            AlterColumn("dbo.UserModels", "UserName", c => c.String(nullable: false));
        }
    }
}
