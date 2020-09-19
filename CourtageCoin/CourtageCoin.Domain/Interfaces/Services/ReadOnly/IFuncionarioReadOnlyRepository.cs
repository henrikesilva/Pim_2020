﻿using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Services.Common;
using CourtageCoin.Domain.Interfaces.Services.ReadOnly.Common;

namespace CourtageCoin.Domain.Interfaces.Services.ReadOnly
{
    public interface IFuncionarioReadOnlyRepository : IServiceBase<Funcionario>, IBaseReadOnlyRepository<Funcionario>
    {
    }
}
