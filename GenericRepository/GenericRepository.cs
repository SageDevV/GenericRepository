using Microsoft.EntityFrameworkCore;

namespace GenericRepository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Db;
        protected readonly DbSet<TEntity> _dbSet;
        protected Repository(DbContext db)
        {
            Db = db;
            _dbSet = db.Set<TEntity>();
        }

        public void AddAsync(TEntity obj)
        {
            _dbSet.AddAsync(obj);
        }

        public void AddRangeAsync(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRangeAsync(entities);
        }

        public void Update(TEntity obj)
        {
            _dbSet.Update(obj);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _dbSet.UpdateRange(entities);
        }

        public void Remove(object id)
        {
            TEntity exists = _dbSet.Find(id);
            _dbSet.Remove(exists);
        }

        public void Remove(TEntity entities)
        {
            _dbSet.Remove(entities);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public IQueryable<TEntity> Query()
        {
            return _dbSet.AsQueryable();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }

        public void Add(TEntity obj)
        {
            _dbSet.Add(obj);
        }
    }
}
