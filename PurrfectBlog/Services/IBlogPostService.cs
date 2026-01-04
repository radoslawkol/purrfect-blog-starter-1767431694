using PurrfectBlog.Models;
using System.Collections.Generic;

namespace PurrfectBlog.Services
{
	public interface IBlogPostService
	{
		void Create(BlogPost post);

		IEnumerable<BlogPost> GetAll();

		BlogPost Get(int id);

		void Edit (BlogPost post);

		void Delete(int id);
	}
}
