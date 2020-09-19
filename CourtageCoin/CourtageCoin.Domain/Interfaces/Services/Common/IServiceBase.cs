namespace CourtageCoin.Domain.Interfaces.Services.Common
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Adicionar(TEntity obj);
        void Atualizar(TEntity obj);
        void Remover(TEntity obj);
        void Dispose();
    }
}
