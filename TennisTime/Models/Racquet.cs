using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TennisTime.Models
{
	public class Racquet
	{
		public int RacquetId { get; set; }

		[Required(ErrorMessage = "Please enter a model.")]
		public string Model { get; set; }

		[Required(ErrorMessage = "Please enter a year.")]
        [Range(1800, 2022, ErrorMessage = "Year must be between 1889 and now.")]
		public int? Year { get; set; }

		[Required(ErrorMessage = "Please enter a make.")]
		public string MakeId { get; set; }

		public Make Make { get; set; }

		[Required(ErrorMessage = "Please enter a price.")]
		public string Price { get; set; }

		public string Slug =>
			Model?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();

	}
}
