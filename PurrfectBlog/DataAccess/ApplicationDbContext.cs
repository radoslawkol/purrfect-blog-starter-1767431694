
using PurrfectBlog.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PurrfectBlog.DataAccess
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(): base("ApplicationDbContext")
		{
		}
		
		public DbSet<BlogPost> BlogPosts { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}

}