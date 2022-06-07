using Microsoft.AspNetCore.Mvc;

namespace AspNetEcommerce.Web.Mvc.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int orderId)
        {
            return View();
        }
    }
}
