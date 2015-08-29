using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCoupons.Domain
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string userName { get; set; }
        public virtual string businessName { get; set; }
        public virtual string address { get; set; }
        public virtual string password { get; set; }
    }
}
