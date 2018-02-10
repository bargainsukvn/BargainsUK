using Autofac;
using BargainsUK.DAL;
using BargainsUK.DAL.Repositories;

namespace BargainsUK.Business
{
    public class DependencyModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CultureRepository>().As<ICultureRepository>();
            builder.RegisterType<CurrencyRepository>().As<ICurrencyRepository>();
            builder.RegisterType<Context>().As<IContext>();
        }
    }
}
