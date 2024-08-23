using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RadioCabProject.Controllers
{
	public class AboutController : Controller
	{
		// GET: About
		public ActionResult Index()
		{
			return View();
		}

	}
}
