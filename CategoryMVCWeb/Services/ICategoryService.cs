using CategoryMVCWeb.Models;

namespace CategoryMVCWeb.Services
{
    public interface ICategoryService
    {
        public IEnumerable<Category> GetCategories();
    }
}
