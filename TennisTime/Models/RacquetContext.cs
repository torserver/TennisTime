using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace TennisTime.Models
{
	public class RacquetContext : DbContext
	{
		public RacquetContext(DbContextOptions<RacquetContext> options)
			: base(options)
		{ }

		public DbSet<Racquet> Racquets { get; set; }
		public DbSet<Make> Make { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Racquet>().HasData(
				new Racquet
				{
					RacquetId = 1,
					Model = "Blade 98 v7",
					MakeId = "A",
					Price = "200",
					Year = 2020
				}
				);
			modelBuilder.Entity<Make>().HasData(
				new Make { MakeId = "A", Name = "Wilson" }
				);
					
		}
	}
}
