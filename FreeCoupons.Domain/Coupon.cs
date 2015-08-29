using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCoupons.Domain
{
    public class Coupon
    {
        public virtual int Id { get; set; }
        public virtual string userName { get; set; }
        public virtual string firstProduct { get; set; }
        public virtual string discount { get; set; }
        public virtual string secondProduct { get; set; }
        public virtual string conditions { get; set; }
        public virtual int count { get; set; }
        public virtual string address { get; set; }
    }
}
