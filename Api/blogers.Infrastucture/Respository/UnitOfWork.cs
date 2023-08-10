using System.Collections;
using blogers.Application.Contracts.Persitence;
using blogers.Infrastucture.Persistence;

namespace blogers.Infrastucture.Respository
{
	public class UnitOfWork:IUnitOfWork
	{
        private readonly FrontendContext _context;
        private Hashtable _repositorys;
        public UnitOfWork(FrontendContext context)
        {
            this._context = context;
        }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IAsycBaseRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            if (_repositorys == null)
            {
                _repositorys = new Hashtable();
            }
            var type = typeof(TEntity).Name;

            if (!_repositorys.ContainsKey(type))
            {
                var repositoryType = typeof(AsycBaseRepository<>);
                var repoistoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context);
                _repositorys.Add(type, repoistoryInstance);
            }
            return (IAsycBaseRepository<TEntity>)_repositorys[type];
        }
    }
}

