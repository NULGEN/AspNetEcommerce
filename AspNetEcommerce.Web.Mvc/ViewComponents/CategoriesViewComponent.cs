﻿using AspNetEcommerce.Business;
using Microsoft.AspNetCore.Mvc;

namespace AspNetEcommerce.Web.Mvc.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryService categoryService;

        public CategoriesViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.MainCategories = categoryService.GetAllMainCategories();

            ViewBag.SubCategories = categoryService.GetAllSubCategories();

            return View();
        }
    }
}
