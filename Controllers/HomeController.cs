using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTestGit.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "Moxxdify this template to jump-start your ASP.NET MVC application. xcxcxcxc";

			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your app description page.";

			//dfdfdfd
			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}
