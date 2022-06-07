using AspNetEcommerce.Data;
using AspNetEcommerce.Data.Entity;

namespace AspNetEcommerce.Business
{
    public interface ICategoryService
    {
        List<Category> GetAllMainCategories();
        List<Category> GetAllSubCategories();
    }

    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _db;

        public CategoryService(AppDbContext db)
        {
            _db = db;
        }

        public List<Category> GetAllMainCategories()
        {
            var list = _db.Categories.Where(e => e.ParentId == null).ToList();

            return list;
        }

        public List<Category> GetAllSubCategories()
        {
            var list = _db.Categories.Where(e => e.ParentId != null).ToList();

            return list;
        }
    }
}
