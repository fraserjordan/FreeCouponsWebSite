using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCoupons.Domain
{
    public interface IFreeCouponDataSource
    {
        IQueryable<Coupon> Coupons { get; set; }
        IQueryable<User> Users { get; set; }
        void Save();
    }
}
