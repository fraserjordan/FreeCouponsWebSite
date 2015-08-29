namespace Coupons.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeConfirmPasswordAttribute : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserModels", "ConfirmPassword", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserModels", "ConfirmPassword", c => c.String());
        }
    }
}
