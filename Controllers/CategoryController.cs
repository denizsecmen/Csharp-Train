using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Train_000.Data;
using Train_000.Models;

namespace Train_000.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Category.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
