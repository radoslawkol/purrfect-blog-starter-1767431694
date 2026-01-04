using Autofac;
using Autofac.Integration.Mvc;
using PurrfectBlog.DataAccess;
using PurrfectBlog.Services;
using System.Reflection;
using System.Web.Mvc;

namespace PurrfectBlog.App_Start
{
	public class AutofacConfig
	{
		public static void RegisterDependencies()
		{
			var builder = new ContainerBuilder();

			builder.RegisterControllers(Assembly.GetExecutingAssembly());

			builder.RegisterType<ApplicationDbContext>()
				   .InstancePerRequest();

			builder.RegisterType<BlogPostService>()
				   .As<IBlogPostService>()
				   .InstancePerRequest();

			var container = builder.Build();
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
		}
	}
}