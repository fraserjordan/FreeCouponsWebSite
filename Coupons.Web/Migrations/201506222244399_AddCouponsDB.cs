namespace Coupons.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCouponsDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CouponModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        FirstItem = c.String(nullable: false),
                        SecondItem = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                        Conditions = c.String(nullable: false),
                        ExpireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        businessName = c.String(nullable: false),
                        address = c.String(nullable: false),
                        password = c.String(nullable: false, maxLength: 100),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
    }
}
