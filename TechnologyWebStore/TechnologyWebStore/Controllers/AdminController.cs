using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnologyWebStore.Models;

namespace TechnologyWebStore.Controllers
{
    public class AdminController : Controller
    {
        private IProductsService _productsService;

        public AdminController(IProductsService serviceProduct)
        {
            _productsService = serviceProduct;
        }

        public IActionResult Products()
        {
            List<ProductModel> productList = _productsService.GetProducts();
            return View(productList);
        }

        public IActionResult UpsertProduct()
        {
            NewProduct newProduct = new NewProduct();
            newProduct.Product = new ProductModel();
            return View(newProduct);
        }
    }
}
