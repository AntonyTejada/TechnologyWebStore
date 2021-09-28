using System.Collections.Generic;
using TechnologyWebStore.Models;

namespace TechnologyWebStore
{
    public interface ICategoriesService
    {
        List<CategoryModel> GetCategories();
    }
}
