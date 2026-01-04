using PurrfectBlog.DataAccess;
using PurrfectBlog.Models;
using System.Collections.Generic;
using System.Linq;

namespace PurrfectBlog.Services
{
	public class BlogPostService : IBlogPostService
	{
		private readonly ApplicationDbContext _context;

		public BlogPostService(ApplicationDbContext context) 
		{
			_context = context;
		}

		public void Create(BlogPost post)
		{
			_context.BlogPosts.Add(post);
			_context.SaveChanges();
		}

		public void Delete(int id)
		{
			throw new System.NotImplementedException();
		}

		public void Edit(BlogPost post)
		{
			throw new System.NotImplementedException();
		}

		public BlogPost Get(int id)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<BlogPost> GetAll()
		{
			return _context.BlogPosts
				.OrderByDescending(post => post.CreatedAt)
				.ToList();
		}
	}
}