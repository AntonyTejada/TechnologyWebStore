using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IActionResult UpsertProduct(int? id)
        {
            NewProduct newProduct = new NewProduct();
            newProduct.CategoryList = GetCategories();

            if (id != null)
            {
                List<ProductModel> productsList = _productsService.GetProducts();
                ProductModel product = productsList.Where(item => item.IdProduct == id).FirstOrDefault();
                newProduct.Product = product;
                return View(newProduct);
            }
            else {
                newProduct.Product = new ProductModel();
            }
            
            return View(newProduct);
        }

        public List<SelectListItem> GetCategories() 
        {
            return new List<SelectListItem>()
            {
                new SelectListItem() {Value = "1" , Text = "Smartphone" },
                new SelectListItem() {Value = "2" , Text = "Consoles" },
                new SelectListItem() {Value = "3" , Text = "Laptops" }
            };
        }
    }
}
