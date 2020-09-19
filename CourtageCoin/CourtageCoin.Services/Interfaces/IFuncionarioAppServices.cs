using CourtageCoin.Services.DTO.Models;

namespace CourtageCoin.Services.Interfaces
{
    public interface IFuncionarioAppServices
    {
        bool EfetuarLogin(string usuario, string senha);
        int IncluirCliente(ClienteDTO clienteDTO);
        ClienteDTO BuscarCliente(int CodigoCliente);        
        int ExcluirCliente(int CodigoCliente);
        int AlterarCliente(int CodigoCliente);
        int RemoverCliente(int CodigoCliente);
    }
}
