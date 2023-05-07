using Bussiness.Abstract;
using Entities.DTOs.Categories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogProject.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _categoryService.GetByAllAsync();
            return View(categories);
        }
    }
}
