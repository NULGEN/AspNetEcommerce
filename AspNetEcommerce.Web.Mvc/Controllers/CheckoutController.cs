using Microsoft.AspNetCore.Mvc;

namespace AspNetEcommerce.Web.Mvc.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
