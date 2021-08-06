using Avalonia;
using Avalonia.ReactiveUI;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.DependencyInjection;
using MixFlow.Core.Data;
using Splat;
using Splat.Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace MixFlow.UI
{
	public class Program
	{
		// Initialization code. Don't use any Avalonia, third-party APIs or any
		// SynchronizationContext-reliant code before AppMain is called: things aren't initialized
		// yet and stuff might break.
		public static void Main(string[] args)
		{
			IServiceCollection services = new ServiceCollection();
			services.UseMicrosoftDependencyResolver();

			RegisterServices(services);
			BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
		}

		// Avalonia configuration, don't remove; also used by visual designer.
		public static AppBuilder BuildAvaloniaApp()
			=> AppBuilder.Configure<App>()
				.UsePlatformDetect()
				.LogToTrace()
				.UseReactiveUI();

		public static void RegisterServices(IServiceCollection services)
		{
			services.RegisterAppDbContext(new SqliteConnectionStringBuilder() 
			{ 
				DataSource = Path.Combine(Environment.CurrentDirectory, "data", "database.db"),
				Mode = SqliteOpenMode.ReadWriteCreate
			}.ToString());
		}
	}
}
