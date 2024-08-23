using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RadioCabProject.Controllers
{
	public class ContactController : Controller
	{
		// GET: Contact
		public ActionResult Index()
		{
			return View();
		}

	}
}
