using blogers.Application.Mapping;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace blogers.Application
{
    public  static class ApplicationServiceRegistracion
	{
		public static IServiceCollection AddApplicationServiceRegistracion(this IServiceCollection service)
		{
			service.AddMediatR(x => x.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
			service.AddAutoMapper(x =>
			{
				x.ShouldMapProperty = p =>
				{
					var setMethod = p.GetSetMethod(nonPublic: true);
					return !(setMethod == null || setMethod.IsPrivate || setMethod.IsFamily);
				};
				x.AddMaps(AutoMappingConfig.RegisterMappings());

			});

			return service;
		}
	}
}

