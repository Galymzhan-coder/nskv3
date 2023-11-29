using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using Models.DTO.Interfaces;
using Services.FND;
using Services.FND.Abstract;
using Services.FND.Interfaces;

namespace Administration.Controllers
{
    public class AdminController : Controller
    {
        private readonly CategoriesService _categoriesService;
        private readonly IServiceProvider _serviceProvider;

        private readonly Dictionary<string, Type> _serviceTypes = new Dictionary<string, Type>
        {
            { "categories", typeof(ICategoriesService) },
            // Добавьте здесь другие маппинги
        };

        /*
        public AdminController(CategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }
        */
        public AdminController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
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

        [HttpGet("IndexCommon"), ApiVersion("1")]
        public IActionResult IndexCommon(string type)//CategoriesService
        {
            if (_serviceTypes.TryGetValue(type.ToLower(), out var serviceType))
            {
                var service = _serviceProvider.GetService(serviceType) as IBaseService;
                //var service = _serviceProvider.GetService(typeof(ICategoriesService)) as IBaseService<IDto>;
                var service1 = _serviceProvider.GetService(typeof(ICategoriesService)) as ICategoriesService;
                var service2 = _serviceProvider.GetService(typeof(CategoriesService)) as CategoriesService;
                var service3 = _serviceProvider.GetService(serviceType);
                var service4 = _serviceProvider.GetService(typeof(CategoriesService));

                //var lst = service != null ? service.Index() : null;
                //var lst1 = service1 != null ? service1.Index(): null;
                var lst2 = service2 != null ? service2.Index() : null;
                //var lst3 = service3 != null ? service3.Index() : null;
                //var lst4 = service4 != null ? service4.Index() : null;

                if (service != null)
                {
                    var lst = service != null ? service.Index() : null;
                    /*
                    var method = serviceType.GetMethod("Index");
                    if (method != null)
                    {
                        var result = method.Invoke(service, null);
                        return Ok(result);
                    }
                    else
                    {
                        return NotFound("Метод 'Index' не найден.");
                    }*/
                    return Ok(lst);
                }

                 return NotFound($"Сервис для типа '{type}' не найден");
            }

            return BadRequest($"Некорректный тип сервиса: {type}");

        }
    }
}
