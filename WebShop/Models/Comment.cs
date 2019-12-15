using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
	public class Comment
	{
		public int CommentID { get; set; }

		[ForeignKey("UserProfile")]
		public string UserProfileId { get; set; }

		[ForeignKey("Product")]
		public string ProductId { get; set; }

		[Required]
		public string Title { get; set; }
		[Required]
		public string Description { get; set; }

		public virtual UserProfile UserProfile { get; set; }

		public virtual Product Product { get; set; }

	}
}
