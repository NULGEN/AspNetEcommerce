using Microsoft.AspNetCore.Mvc;

namespace AspNetEcommerce.Web.Mvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
