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

		public void Update(BlogPost post)
		{
			var existingPost = _context.BlogPosts.Find(post.Id);
			if (existingPost is null)
			{
				return;
			}

			existingPost.Title = post.Title;
			existingPost.Content = post.Content;
			existingPost.Category = post.Category;

			_context.SaveChanges();
		}

		public BlogPost GetById(int id)
		{
			return _context.BlogPosts.Find(id);
		}

		public IEnumerable<BlogPost> GetAll()
		{
			return _context.BlogPosts
				.OrderByDescending(post => post.CreatedAt)
				.ToList();
		}

		public IEnumerable<BlogPost> GetLatest(int count)
		{
			return _context.BlogPosts
				.OrderByDescending(post => post.CreatedAt)
				.Take(count)
				.ToList();
		}
	}
}