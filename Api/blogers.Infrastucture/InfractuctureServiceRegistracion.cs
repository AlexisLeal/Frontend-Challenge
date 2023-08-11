using blogers.Application.Contracts.Persitence;
using blogers.Infrastucture.Persistence;
using blogers.Infrastucture.Respository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace blogers.Infrastucture
{
    public static class InfractuctureServiceRegistracion
	{
		public static IServiceCollection AddInfractuctureServiceRegistracion(this IServiceCollection services, IConfiguration configuraration)
		{

            services.AddDbContext<FrontendContext>(c => c.UseSqlServer(configuraration.GetConnectionString("frontend")));
			services.AddScoped(typeof(IAsycBaseRepository<>), typeof(AsycBaseRepository<>));
			services.AddScoped<IUnitOfWork, UnitOfWork>();
			return services;

		}
	}
}

