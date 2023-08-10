namespace blogers.Application.Contracts.Persitence
{
    public interface IUnitOfWork : IDisposable
	{
		IAsycBaseRepository<TEntity> Repository<TEntity>() where TEntity : class;

		Task<int> Complete();

	}
}

