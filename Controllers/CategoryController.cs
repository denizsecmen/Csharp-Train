using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Train_000.Data;
using Train_000.Models;
using System;
using System.Linq;
using System.Collections.Generic;


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
    }
}
