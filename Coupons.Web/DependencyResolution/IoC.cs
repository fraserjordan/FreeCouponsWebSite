using StructureMap;
using Coupons.Web.Infrastructure;

namespace Coupons.Web
{
    public static class IoC
    {
        public static IContainer Initialize()
        {
            ObjectFactory.Initialize(x =>
            {
                x.Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });
                //x.For<IFreeCouponDataSource>().HttpContextScoped().Use<UserDb>();
            });
            return ObjectFactory.Container;
        }
    }
}