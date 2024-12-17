using System.ComponentModel.DataAnnotations;
namespace Movies.Models
{
	public class Movie
	{
		public int MovieId { get; set; }

		[Required(ErrorMessage="Please Enter a Name")]
		public string Name { get; set; } = string.Empty;

		[Required(ErrorMessage ="Please enter a year")]
		[Range(1900,2024, ErrorMessage="Year must be between 1900 and 2024")]
		public int? Year { get; set; }

		[Required(ErrorMessage = "Please enter a rating")]
		public int? Rating { get; set; }



	}

}

