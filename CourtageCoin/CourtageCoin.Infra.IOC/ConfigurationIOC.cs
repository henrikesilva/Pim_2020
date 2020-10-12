﻿using Autofac;
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
            builder.RegisterType<UsuarioAppService>().As<IUsuarioAppService>();
            builder.RegisterType<FuncionarioAppService>().As<IFuncionarioAppService>();
            #endregion

            #region IOC SERVICES
            builder.RegisterType<UsuarioService>().As<IUsuarioService>();
            builder.RegisterType<FuncionarioService>().As<IFuncionarioService>();
            #endregion

            #region IOC REPOSITORIES
            builder.RegisterType<UsuarioRepository>().As<IUsuarioRepository>();
            builder.RegisterType<FuncionarioRepository>().As<IFuncionarioRepository>();
            #endregion

            #endregion
        }
    }
}
