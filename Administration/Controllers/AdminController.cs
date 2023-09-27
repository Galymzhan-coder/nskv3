using Microsoft.AspNetCore.Mvc;
using Services.FND;

namespace Administration.Controllers
{
    public class AdminController : Controller
    {
        private readonly CategoriesService _categoriesService;

        public AdminController(CategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        [HttpGet("Index"), ApiVersion("1")]
        public IActionResult Index()
        {
            var lst = _categoriesService.Index();
            return Ok(lst);
        }

        [HttpGet("CategoryIerarchyList"), ApiVersion("1")]
        public IActionResult GetCategoryIerarchyList()
        {
            var lst = _categoriesService.getCategoryHierarchyLst();

            return Ok(lst);
        }

        [HttpGet("GetCategoryItem"), ApiVersion("1")]
        public IActionResult GetCategoryItem(int id)
        {
            var item = _categoriesService.getCategoryItem(id);
            return Ok(item);
        }
    }
}
