using AspNetEcommerce.Data;
using AspNetEcommerce.Data.Entity;

namespace AspNetEcommerce.Business
{
    public interface IProductService
    {
        List<Product> GetAllProductsByCategoryId(int categoryId);

        List<Product> GetAllFeaturedProducts();
    }

    public class ProductService : IProductService
    {
        private readonly AppDbContext _db;

        public ProductService(AppDbContext db)
        {
            _db = db;
        }

        public List<Product> GetAllProductsByCategoryId(int categoryId)
        {
            var list = _db.Products.Where(e => e.CategoryId == categoryId).ToList();

            return list;
        }

        public List<Product> GetAllFeaturedProducts()
        {
            var list = _db.Products.Where(e => e.IsFeatured == true).ToList();

            return list;
        }
    }
}
