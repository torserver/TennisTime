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
					Price = 200,
					Year = 2020
				},
				new Racquet
				{
					RacquetId = 2,
					Model = "Pro Staff",
					MakeId = "A",
					Price = 200,
					Year = 2018
				},
				new Racquet
				{
					RacquetId = 3,
					Model = "Aero Pro Drive",
					MakeId = "B",
					Price = 180,
					Year = 2019
				},
				new Racquet
				{
					RacquetId = 4,
					Model = "Vcore 98",
					MakeId = "C",
					Price = 200,
					Year = 2021
				}
				);
			modelBuilder.Entity<Make>().HasData(
				new Make { MakeId = "A", Name = "Wilson" },
				new Make { MakeId = "B", Name = "Babolat" },
				new Make { MakeId = "A", Name = "Yonex" }
				);
					
		}
	}
}
