using Microsoft.AspNetCore.Mvc;

namespace AspNetEcommerce.Web.Mvc.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        public SliderViewComponent() { }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
