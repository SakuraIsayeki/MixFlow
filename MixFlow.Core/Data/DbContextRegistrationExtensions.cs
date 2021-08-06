using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MixFlow.Core.Data
{
	public static class DbContextRegistrationExtensions
	{
		public static IServiceCollection RegisterAppDbContext(this IServiceCollection services, string connectionString)
		{
			services.AddDbContextFactory<AppDbContext>(builder =>
			{
				builder.UseSqlite(connectionString, db => {	});

				builder.EnableSensitiveDataLogging();
				builder.EnableDetailedErrors();
			});

			return services;
		}
	}
}
