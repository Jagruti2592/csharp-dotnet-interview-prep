using System;
using Microsoft.EntityFrameworkCore;
using SmartCommerce.Domain.Entities;


namespace SmartCommerce.Infrastructure.Data
{

	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		public DbSet<User> Users { get; set; }
	}
}