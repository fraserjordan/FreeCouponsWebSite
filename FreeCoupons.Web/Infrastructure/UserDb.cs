using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FreeCoupons.Domain;
using System.Data.Entity;

namespace FreeCoupons.Web.Infrastructure
{
    public class UserDb : DbContext, IFreeCouponDataSource
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Coupon> Coupons { get; set; }



        IQueryable<User> IFreeCouponDataSource.Users
        {
            get
            {
                return Users;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        IQueryable<Coupon> IFreeCouponDataSource.Coupons
        {
            get
            {
                return Coupons;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}