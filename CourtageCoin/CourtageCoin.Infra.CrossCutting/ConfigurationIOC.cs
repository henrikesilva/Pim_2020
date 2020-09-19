using Autofac;
using CourtageCoin.Domain.Interfaces.Repositories;
using CourtageCoin.Domain.Interfaces.Services;
using CourtageCoin.Domain.Services;
using CourtageCoin.Infra.Data.Repositories;
using CourtageCoin.Services.Interfaces;
using CourtageCoin.Services.Services;

namespace CourtageCoin.Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Apllication
            builder.RegisterType<CarteiraAppService>().As<ICarteiraAppServices>();
            #endregion

            #region IOC Services
            builder.RegisterType<CarteiraService>().As<ICarteiraService>();
            #endregion

            #region IOC Repository SQL
            builder.RegisterType<CarteiraRepository>().As<ICarteiraRepository>();
            #endregion

            #endregion
        }
    }
}
