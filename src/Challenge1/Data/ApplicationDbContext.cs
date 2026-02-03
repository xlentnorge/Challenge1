using Challenge1.Models;
using Microsoft.EntityFrameworkCore;

namespace Challenge1.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
	public DbSet<Customer> Customers { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseInMemoryDatabase(DbData.DbName);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Customer>().HasKey(c => c.Id);
		modelBuilder.Entity<Customer>().Property(c => c.FirstName).IsRequired();
		modelBuilder.Entity<Customer>().Property(c => c.LastName).IsRequired();
	}
}