using AspNetEcommerce.Business;
using Microsoft.AspNetCore.Mvc;

namespace AspNetEcommerce.Web.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IProductService productService;

        public CategoryController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index(int id)
        {
            var products = productService.GetAllProductsByCategoryId(id);

            ViewBag.Products = products;

            return View();
        }
    }
}
