using CategoryMVCWeb.Data;
using CategoryMVCWeb.Models;

namespace CategoryMVCWeb.Services
{
    public class CategoryService : ICategoryService
    {
        public readonly DataContext _db;
        public CategoryService(DataContext db)
        {
            _db = db;
        }
        public IEnumerable<Category> GetCategories()
        {
            return _db.Categories.Select(s => s).ToList();
        }
    }
}
