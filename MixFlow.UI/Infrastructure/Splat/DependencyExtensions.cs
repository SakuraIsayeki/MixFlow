using Splat;
using System;

namespace MixFlow.UI.Infrastructure.Splat
{
	public static class DependencyExtensions
	{
		public static TService GetRequiredService<TService>(this IReadonlyDependencyResolver resolver)
		{
			if (resolver.GetService<TService>() is not TService service) // Splat is not able to resolve type for us
			{
				throw new InvalidOperationException($"Failed to resolve object of type {typeof(TService)}"); // throw error with detailed description
			}

			return service; // return instance if not null
		}
	}
}
