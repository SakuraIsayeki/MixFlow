using Microsoft.EntityFrameworkCore;
using MixFlow.Core.Data.Models;



namespace MixFlow.Core.Data
{
	public class AppDbContext : DbContext
	{
		public DbSet<Track> Tracks { get; init; }
		public DbSet<Artist> Artists { get; init; }
		public DbSet<Album> Albums { get; init; }
		public DbSet<Genre> Genres { get; init; }


		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
