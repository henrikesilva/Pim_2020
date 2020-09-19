using CourtageCoin.Services.DTO.Models;

namespace CourtageCoin.Services.Interfaces
{
    public interface IClienteAppServices
    {
        void EfetuarLogin(string usuario, string senha);
        ClienteDTO EditarPerfil(int clienteID);
    }
}
