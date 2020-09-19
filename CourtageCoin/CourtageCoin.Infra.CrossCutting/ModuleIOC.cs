using Autofac;

namespace CourtageCoin.Infra.CrossCutting.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region Carrega IOC
            ConfigurationIOC.load(builder);
            #endregion
        }
    }
}
