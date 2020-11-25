using Autofac;
using CourtageCoin.Application.Interface;
using CourtageCoin.Application.Services;
using CourtageCoin.Domain.Interfaces.Repositories;
using CourtageCoin.Domain.Interfaces.Services;
using CourtageCoin.Domain.Services;
using CourtageCoin.Infra.Data.Repositories;

namespace CourtageCoin.Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC APPLICATION
            builder.RegisterType<CarteiraAppService>().As<ICarteiraAppService>();
            builder.RegisterType<ClienteAppService>().As<IClienteAppService>();
            builder.RegisterType<EnderecoAppService>().As<IEnderecoAppService>();
            builder.RegisterType<FuncionarioAppService>().As<IFuncionarioAppService>();
            builder.RegisterType<PerfilAppService>().As<IPerfilAppService>();
            builder.RegisterType<TransacaoAppService>().As<ITransacaoAppService>();
            builder.RegisterType<UsuarioAppService>().As<IUsuarioAppService>();
            #endregion

            #region IOC SERVICES
            builder.RegisterType<CarteiraService>().As<ICarteiraService>();
            builder.RegisterType<ClienteService>().As<IClienteService>();
            builder.RegisterType<EnderecoService>().As<IEnderecoService>();
            builder.RegisterType<FuncionarioService>().As<IFuncionarioService>();
            builder.RegisterType<PerfilService>().As<IPerfilService>();
            builder.RegisterType<TransacaoService>().As<ITransacaoService>();
            builder.RegisterType<UsuarioService>().As<IUsuarioService>();
            #endregion

            #region IOC REPOSITORIES
            builder.RegisterType<CarteiraRepository>().As<ICarteiraRepository>();
            builder.RegisterType<ClienteRepository>().As<IClienteRepository>();
            builder.RegisterType<EnderecoRepository>().As<IEnderecoRepository>();
            builder.RegisterType<FuncionarioRepository>().As<IFuncionarioRepository>();
            builder.RegisterType<PerfilRepository>().As<IPerfilRepository>();
            builder.RegisterType<TransacaoRepository>().As<ITransacaoRepository>();
            builder.RegisterType<UsuarioRepository>().As<IUsuarioRepository>();
            #endregion

            #endregion
        }
    }
}
