using Autofac;

namespace CourtageCoin.Infra.CrossCutting.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region CARREGA IOC

            ConfigurationIOC.Load(builder);

            #endregion
        }
    }
}
