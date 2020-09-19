using CourtageCoin.Services.DTO.Models;

namespace CourtageCoin.Services.Interfaces
{
    public interface ICarteiraAppServices
    {
        void IncluirAtivo(CarteiraDTO ativo);
        CarteiraDTO ConsultarAtivo(string nome);
        void VenderAtivo(int codigoAtivo);

    }
}
