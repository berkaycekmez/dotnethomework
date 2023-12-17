using dotnethomework.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace dotnethomework.Context
{
	public class MyDbContext:DbContext
	{
		public MyDbContext(DbContextOptions options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Blog> Blogs { get; set; }	

	}
}
