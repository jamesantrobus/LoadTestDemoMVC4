namespace LoadTestDemoMVC4.Controllers
{
	using System.Web.Mvc;

	public class HomeController : Controller
	{
		[HttpGet]
		public ActionResult Index()
		{
			var viewModel = new HomeViewModel();

			return View(viewModel);
		}

		[ValidateAntiForgeryToken]
		[HttpPost]
		public ActionResult Index(HomeViewModel viewModel)
		{
			return RedirectToAction("AnotherPage");
		}

		[HttpGet]
		public ActionResult AnotherPage()
		{
			return View();
		}
	}

	public class HomeViewModel
	{
		public string Name { get; set; }
	}
}
