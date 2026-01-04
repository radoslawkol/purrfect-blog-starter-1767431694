using PurrfectBlog.Models;
using System.Collections.Generic;

namespace PurrfectBlog.Services
{
	public interface IBlogPostService
	{
		void Create(BlogPost post);

		IEnumerable<BlogPost> GetAll();

		BlogPost GetById(int id);

		void Update (BlogPost post);

		void Delete(int id);

		IEnumerable<BlogPost> GetLatest(int count);
	}
}
