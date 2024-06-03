using Domain.Entity;
using Infrastructure.Data;

namespace Domain.Repository.Base
{
    public abstract class Repository<TEntity>
        where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext DbContext;
        protected Repository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public void Add(TEntity entity)
        {
            DbContext.Set<TEntity>().Add(entity);   
        }
        public void Update(TEntity entity)
        {
            DbContext.Set<TEntity>().Update (entity);
        }
        public void Remove(TEntity entity)
        {
            DbContext.Set<TEntity>().Remove(entity);
        }
    }
}
