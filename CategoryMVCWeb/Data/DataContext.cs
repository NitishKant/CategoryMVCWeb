using CategoryMVCWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CategoryMVCWeb.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
