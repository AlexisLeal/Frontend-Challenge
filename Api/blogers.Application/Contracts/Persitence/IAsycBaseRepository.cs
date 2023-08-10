using System.Linq.Expressions;

namespace blogers.Application.Contracts.Persitence
{
	public interface IAsycBaseRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        string includeString = null,
                                        bool disableTrancking = true);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        List<Expression<Func<T, object>>> include = null,
                                        bool disableTrancking = true);

        Task<T> GetByIdAsync(int id);

        Task<T> AddAsync(T entity);

        Task<T> UpdatedAsync(T entity);

        Task DeleteAsync(T entity);

        void AddEntity(T entity);

        void UpdatedEntity(T entity);

        void DeleteEntity(T entity);
    }
}

