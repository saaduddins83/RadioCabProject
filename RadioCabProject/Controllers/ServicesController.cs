using Microsoft.AspNetCore.Mvc;

namespace RadioCabProject.Controllers
{
	public class ServicesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
