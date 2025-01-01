using Microsoft.AspNetCore.Mvc;

namespace Train_000.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
