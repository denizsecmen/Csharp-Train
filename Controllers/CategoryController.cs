using System;
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
        [HttpPost]
		public IActionResult Create(Category obj)
		{
            if (obj.Name.ToLower() == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "DisplayOrder can't same with Name");
            }
            if (this.ModelState.IsValid)
            {
                _db.Category.Add(obj);
                _db.SaveChanges();
				return RedirectToAction("Index");

			}
            return View();
		}
		[HttpGet]
		public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if(ModelState.IsValid)
            {
                _db.Category.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
			if (id == null || id == 0)
			{
				return NotFound();
			}
			Category? categoryFromDb = _db.Category.Find(id);
			if (categoryFromDb == null)
			{
				return NotFound();
			}
			return View(categoryFromDb);
        }
    }
}
