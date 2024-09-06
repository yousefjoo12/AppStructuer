using Microsoft.AspNetCore.Mvc;

namespace AppStructuer.Controllers
{
	public class Movie : Controller
	{
		public IActionResult GetMovie(int id)
		{
			//ContentResult Result = new ContentResult();
			//Result.Content = $"Movie With id ={id}";
			//return Result;
			//return $"Movie With id ={id}";
			return Content($"Movie With id ={id}","txt/html");

		}
		public IActionResult Index()
		{
			//RedirectResult ReResult = new RedirectResult("https://localhost:44343/Movie/GetMovie/10");
			//return ReResult;
			//return "Index";
			//return Redirect("{BaseUrl}/Movie/GetMovie/10");
			return RedirectToAction(nameof(GetMovie), new {id=10});
		}
		public ViewResult Hamada()
		{
			return View();
		}
	}
}
