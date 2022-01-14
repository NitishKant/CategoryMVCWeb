using CategoryMVCWeb.Data;
using CategoryMVCWeb.Models;
using CategoryMVCWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace CategoryMVCWeb.Controllers
{
    public class CategoryController : Controller
    {
        public readonly DataContext _db;
        public readonly ICategoryService _dbServices;

        public CategoryController(DataContext db, ICategoryService dbServices)
        {
            _db = db;
            _dbServices = dbServices;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategory = _db.Categories;
            return View(objCategory);
        }

        public IActionResult List()
        {
            IEnumerable<Category> objCategory = _db.Categories.Select(s => s).ToList();
            return View(objCategory);
        }

        public IActionResult Services()
        {
            return View(_dbServices.GetCategories());
        }
    }
}
