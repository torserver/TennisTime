using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisTime.Models
{
	public class Racquet
	{
		public int RacquetId { get; set; }
		public string Model { get; set; }
		public int? Year { get; set; }
		public string MakeId { get; set; }
		public Make Make { get; set; }
		public string Price { get; set; }

		public string Slug =>
			Model?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();

	}
}
