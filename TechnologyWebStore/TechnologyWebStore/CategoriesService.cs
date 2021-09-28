using System.Collections.Generic;
using TechnologyWebStore.Models;

namespace TechnologyWebStore
{
    public class CategoriesService : ICategoriesService
    {
        public List<CategoryModel> GetCategories()
        {
            List<CategoryModel> categories = new List<CategoryModel>();
            categories.Add(new CategoryModel() { IdCategory = 1, NameCategory = "Smartphone", DescriptionCategory = "Find the best discounts on cell phones", ImageUrlCategory = "https://www.pngitem.com/pimgs/m/9-95038_mobile-app-all-company-mobile-png-transparent-png.png" });
            categories.Add(new CategoryModel() { IdCategory = 2, NameCategory = "Consoles", DescriptionCategory = "Find the best consoles of the moment such as Playstation, Xbox and Nintendo", ImageUrlCategory = "https://media.tycsports.com/files/2020/12/28/166202/playstation-5-xbox-series-xs.jpg" });
            categories.Add(new CategoryModel() { IdCategory = 3, NameCategory = "Laptops", DescriptionCategory = "Innovative Technology to Study, Work and Have Fun.", ImageUrlCategory = "https://www.muycomputerpro.com/wp-content/uploads/2020/06/port%C3%A1tiles_LIFEBOOK_Fujitsu.jpg" });

            return categories;
        }
    }
}
