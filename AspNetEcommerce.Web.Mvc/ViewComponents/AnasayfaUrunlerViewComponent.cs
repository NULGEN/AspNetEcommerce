using AspNetEcommerce.Business;
using AspNetEcommerce.Data.Entity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetEcommerce.Web.Mvc.ViewComponents
{
    public class AnasayfaUrunlerViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public AnasayfaUrunlerViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string listType)
        {
            var products = new List<Product>();

            if (listType == "OneCikan")
            {
                products = _productService.GetAllFeaturedProducts();
            }
            else if (listType == "CokSatan")
            {
                //products = _productService.GetAllFeaturedProducts();
            }
            else if (listType == "Indirimli")
            {
                //products = _productService.GetAllFeaturedProducts();
            }

            ViewBag.Products = products;

            return View();
        }
    }
}
