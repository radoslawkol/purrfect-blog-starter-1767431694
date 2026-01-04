using PurrfectBlog.Models;
using PurrfectBlog.Services;
using System.Web.Mvc;

namespace PurrfectBlog.Controllers
{
	public class BlogPostsController : Controller
	{
		private readonly IBlogPostService _blogPostService;
		private const int HomePageRecentPostCount = 3;

		public BlogPostsController(IBlogPostService blogPostService)
		{
			_blogPostService = blogPostService;
		}

		public ActionResult Index()
		{
			var latestPosts = _blogPostService.GetLatest(HomePageRecentPostCount);
			return View(latestPosts);
		}

		public ActionResult CreatePost()
		{
			return View("CreatePost");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult CreatePost(BlogPost post)
		{
			if (!ModelState.IsValid)
			{
				return View(post);
			}

			_blogPostService.Create(post);
			return RedirectToAction("Posts");
		}

		public ActionResult Posts()
		{
			var posts = _blogPostService.GetAll();
			return View("Posts", posts);
		}

		public ActionResult Details(int id)
		{
			var post = _blogPostService.GetById(id);
			if (post == null)
			{
				return HttpNotFound();
			}
			return View("Details", post);
		}
	}
}