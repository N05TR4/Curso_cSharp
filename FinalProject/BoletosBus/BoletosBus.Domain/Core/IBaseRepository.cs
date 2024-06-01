using System.Linq.Expressions;


namespace BoletosBus.Domain.Core
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task Save(TEntity entity);

        Task Save(List<TEntity> entities);

        Task Update(TEntity entity);

        Task Update(List<TEntity> entities);

        Task<TEntity> GetById(int Id);

        Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter);

        Task<TEntity> Delete(int Id);
    }
}
