using Autofac;
using CourtageCoin.Application.Interfaces;
using CourtageCoin.Application.Services;
using CourtageCoin.Domain.Interfaces.Repositories.ReadOnly;
using CourtageCoin.Domain.Interfaces.Repositories.Write;
using CourtageCoin.Domain.Interfaces.Services;
using CourtageCoin.Domain.Services;
using CourtageCoin.Infra.Data.DapperRepositories;
using CourtageCoin.Infra.Data.EntityFrameworkRepositories;

namespace CourtageCoin.Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region [REGISTRA IOC]

            #region [IOC APPLICATION]
            builder.RegisterType<CarteiraAppService>().As<ICarteiraAppService>();
            builder.RegisterType<ClienteAppService>().As<IClienteAppService>();
            builder.RegisterType<FuncionarioAppService>().As<IFuncionarioAppService>();
            builder.RegisterType<UsuarioAppService>().As<IUsuarioAppService>();
            #endregion

            #region [IOC SERVICES]
            builder.RegisterType<CarteiraService>().As<ICarteiraService>();
            builder.RegisterType<ClienteService>().As<IClienteService>();
            builder.RegisterType<FuncionarioService>().As<IFuncionarioService>();
            builder.RegisterType<PessoaFisicaService>().As<IPessoaFisicaService>();
            builder.RegisterType<PessoaJuridicaService>().As<IPessoaJuridicaService>();
            builder.RegisterType<UsuarioService>().As<IUsuarioService>();
            #endregion

            #region[IOC REPOSITORIES SQL]
            //ENTITY FRAMEWORK
            builder.RegisterType<CarteiraEntityFrameworkRepository>().As<ICarteiraWriteRepository>();
            builder.RegisterType<ClienteEntityFrameworkRepository>().As<IClienteWriteRepository>();
            builder.RegisterType<FuncionarioEntityFrameworkRepository>().As<IFuncionarioWriteRepository>();
            builder.RegisterType<PessoaFisicaEntityFrameworkRepository>().As<IPessoaFisicaWriteRepository>();
            builder.RegisterType<PessoaJuridicaEntityFrameworkRepository>().As<IPessoaJuridicaWriteRepository>();
            builder.RegisterType<UsuarioEntityFrameworkRepository>().As<IUsuarioWriteRepository>();

            //DAPPER
            builder.RegisterType<CarteiraDapperRepository>().As<ICarteiraReadOnlyRepository>();
            builder.RegisterType<ClienteDapperRepository>().As<IClienteReadOnlyRepository>();
            builder.RegisterType<FuncionarioDapperRepository>().As<IFuncionarioReadOnlyRepository>();
            builder.RegisterType<PessoaFisicaDapperRepository>().As<IPessoaFisicaReadOnlyRepository>();
            builder.RegisterType<PessoaJuridicaDapperRepository>().As<IPessoaJuridicaReadOnlyRepository>();
            builder.RegisterType<UsuarioDapperRepository>().As<IUsuarioReadOnlyRepository>();
            #endregion
            
            #endregion
        }
    }
}