using System;
using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
	public class MovieForm
	{
		//Class for the form with required fields and error messages
		[Key]
		[Required]
		public int AppId { get; set; }

		[Required(ErrorMessage ="You Need A Title!!!")]
		public string Title { get; set; }

		[Required(ErrorMessage ="You Need A Year!!!")]
		public int Year { get; set; }

		[Required(ErrorMessage = "You Need A Director!!!")]
		public string Director { get; set; }

		[Required(ErrorMessage = "You Need A Rating!!!")]
		public string Rating { get; set; }

		public bool Edited { get; set; }

		public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }


		
		//Build Foreign key relationship
        public int CategoryID { get; set; }

		public Category? Category { get; set; }


    }
}

