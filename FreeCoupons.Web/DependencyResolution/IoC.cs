using StructureMap;
using FreeCoupons.Domain;
using FreeCoupons.Web.Infrastructure;

namespace FreeCoupons.Web {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<IFreeCouponDataSource>().HttpContextScoped().Use<UserDb>();
                        });
            return ObjectFactory.Container;
        }
    }
}