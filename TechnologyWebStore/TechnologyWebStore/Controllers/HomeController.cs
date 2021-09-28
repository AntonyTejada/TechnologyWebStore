using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using TechnologyWebStore.Models;

namespace TechnologyWebStore.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        private ICategoriesService _categoriesService;

        public HomeController(ICategoriesService service) //, IProductsService serviceProduct)
        {
            _categoriesService = service;
            //_productsService = serviceProduct;
        }

        public class CollectionDataModel {
            public CategoryModel Categories { get; set; }
            public ProductModel Products { get; set; }
        }

        public IActionResult Index()
        {
            var categoryList = _categoriesService.GetCategories();
            return View(categoryList);
        }

        public IActionResult DetailsCategories(int id) {

            //dynamic detailCategory = new ExpandoObject();

            var categoryList = _categoriesService.GetCategories();
            CategoryModel category = categoryList.Where(x => x.IdCategory == id).FirstOrDefault();

            //var productList = _productsService.GetProducts();
            //ProductModel product = productList.Where(a => a.CategoryId == id).FirstOrDefault();

            //CollectionDataModel model = new CollectionDataModel();
            //model.Categories = categoryList.Where(x => x.IdCategory == id).FirstOrDefault();
            //model.Products = productList.Where(a => a.CategoryId == id).FirstOrDefault();

            //detailCategory.Category = _categoriesService.GetCategories(); //categoryList.Where(x => x.IdCategory == id).FirstOrDefault();
            //detailCategory.Product = _productsService.GetProducts(); //productList.Where(a => a.CategoryId == id).FirstOrDefault();

            //return View(model);
            return View(category);
            //return View(detailCategory);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
