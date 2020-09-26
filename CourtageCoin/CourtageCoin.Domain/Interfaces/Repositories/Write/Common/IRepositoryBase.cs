namespace CourtageCoin.Domain.Interfaces.Repositories.Write.Common
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Adicionar(TEntity obj);
        void Atualizar(TEntity obj);
        void Remover(TEntity obj);
        void Dispose();
    }
}
