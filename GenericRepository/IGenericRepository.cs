namespace GenericRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void AddRange(IEnumerable<TEntity> entities);

        void UpdateRange(IEnumerable<TEntity> entities);

        void RemoveRange(IEnumerable<TEntity> entities);

        void Add(TEntity obj);

        IQueryable<TEntity> Query();

        TEntity GetById(object id);

        void Remove(object id);

        void Remove(TEntity entities);

        void Update(TEntity obj);
    }
}
