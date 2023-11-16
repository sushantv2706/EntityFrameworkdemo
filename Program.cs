using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemoo
{
	public class Post
	{
		public int PostID { get; set; }
		public string PostPublisherName { get; set; }
		public DateTime PostPublishDate { get; set; }
		public string PostContent { get; set; }
	}

	class BlogDbContext : DbContext
	{
		public DbSet<Post> posts { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{
		}
	}
}
