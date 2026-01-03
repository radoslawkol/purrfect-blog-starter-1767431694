using System.Web.Mvc;

namespace PurrfectBlog.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}