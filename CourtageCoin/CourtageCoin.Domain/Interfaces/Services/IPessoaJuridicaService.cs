﻿using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Services.Common;
using CourtageCoin.Domain.Interfaces.Services.Write.Common;

namespace CourtageCoin.Domain.Interfaces.Services
{
    public interface IPessoaJuridicaService : IWriteServiceBase<PessoaJuridica>, IReadOnlyServiceBase<PessoaJuridica>
    {
    }
}
