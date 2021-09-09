using System.Collections.Generic;

namespace Alpha.Repository
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
        TEntity Get(int id);
        void Create(TEntity item);
        void Update(TEntity item);
        TEntity Delete(int id);
    }
}