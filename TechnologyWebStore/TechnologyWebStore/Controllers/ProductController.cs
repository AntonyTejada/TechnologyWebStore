using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TechnologyWebStore.Models;

namespace TechnologyWebStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductsService _productsService;

        public ProductController(IProductsService serviceProduct)
        {
            _productsService = serviceProduct;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductsCategory(int id)
        {
            var productList = _productsService.GetProducts();
            List<ProductModel> product = productList.Where(a => a.CategoryId == id).ToList();
            return View(product);
        }
    }
}
