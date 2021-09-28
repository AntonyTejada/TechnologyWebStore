using System.Collections.Generic;
using TechnologyWebStore.Models;

namespace TechnologyWebStore
{
    public interface IProductsService
    {
        List<ProductModel> GetProducts();
    }
}
