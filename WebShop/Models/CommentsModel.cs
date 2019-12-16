using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
	public class CommentsModel
	{
		public CommentsModel()
		{
			this.Comments = new List<Comment>();
		}
		public IList<Comment> Comments { get; set; }
	}
}
