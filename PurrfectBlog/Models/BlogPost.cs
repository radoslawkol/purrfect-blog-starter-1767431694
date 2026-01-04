using System;
using System.ComponentModel.DataAnnotations;

namespace PurrfectBlog.Models
{ 
	public class BlogPost
	{
		public int Id { get; set; }

		[Required]
		[StringLength(200)]
		public string Title { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		public string Author { get; set; }

		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
	}
}
