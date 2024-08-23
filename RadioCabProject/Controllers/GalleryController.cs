using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RadioCabProject.Controllers
{
	public class GalleryController : Controller
	{
		// GET: Gallery
		public ActionResult Index()
		{
			return View();
		}

	}
}
