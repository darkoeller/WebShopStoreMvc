using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShopStoreMvc01.Models;

namespace WebShopStoreMvc01.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			 : base(options)
		{
		}
		public DbSet<Category> Category { get; set; }
		public DbSet<ProductCategory> ProductCategory { get; set; }
		public DbSet<Product> Product { get; set; }
		public DbSet<Orders> Order { get; set; }
		public DbSet<OrderItem> OrderItem { get; set; }
	}
}