using System.Collections.Generic;
using TechnologyWebStore.Models;

namespace TechnologyWebStore
{
    public class ProductsService : IProductsService
    {
        public List<ProductModel> GetProducts()
        {
            List<ProductModel> products = new List<ProductModel>();
            products.Add(new ProductModel { IdProduct = 1, NameProduct = "Samsung", DescriptionProduct = "Samsung A30", ImageUrlProduct= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTIUiTeL7gMxlDe83G3vrKcXmP7kov8xx6yvUrOKcAgwyfIEklr7N61p2ALbCpnPCuAn1Y&usqp=CAU", MemoryProduct = 6, StorageCapacityProduct = 64, PriceProduct=550000 , ResolutionImageProduct="800x700" , CategoryId = 1 });
            products.Add(new ProductModel { IdProduct = 2, NameProduct = "Xiaomi", DescriptionProduct = "Redmi Note 9", ImageUrlProduct= "https://cdn.elgrupoinformatico.com/Noticias/2021/07/redmi-note-9-colores-1200x675.webp", MemoryProduct = 8, StorageCapacityProduct = 128, PriceProduct = 750000, ResolutionImageProduct = "1200x720" , CategoryId = 1 });
            products.Add(new ProductModel { IdProduct = 3, NameProduct = "Huawei", DescriptionProduct = "Y9A", ImageUrlProduct= "https://www.comunidad-ola.com/portal/images/Moviles/Huawei_Colombia/2020/huawei_Y9a_colombia.jpg", MemoryProduct = 8, StorageCapacityProduct = 264, PriceProduct = 950000, ResolutionImageProduct = "1366x768", CategoryId = 1 });

            products.Add(new ProductModel { IdProduct = 4, NameProduct = "Xbox", DescriptionProduct = "Xbox Series X", ImageUrlProduct= "https://as.com/meristation/imagenes/2020/11/05/reportajes/1604585433_047408_1604585657_noticia_normal.jpg", MemoryProduct = 10, StorageCapacityProduct = 1000, PriceProduct = 2550000, ResolutionImageProduct = "FHD 4K", CategoryId = 2 });
            products.Add(new ProductModel { IdProduct = 5, NameProduct = "Playstation", DescriptionProduct = "Playstation 5", ImageUrlProduct= "https://cdn.computerhoy.com/sites/navi.axelspringer.es/public/styles/1200/public/media/image/2020/06/playstation-5-1964465.jpg?itok=EXk3Upcm", MemoryProduct = 10, StorageCapacityProduct = 1000, PriceProduct = 2550000, ResolutionImageProduct = "FHD 4K", CategoryId = 2 });
            products.Add(new ProductModel { IdProduct = 6, NameProduct = "Nintendo", DescriptionProduct = "Nintendo Switch", ImageUrlProduct= "https://m.media-amazon.com/images/I/61-PblYntsL._AC_SL1500_.jpg", MemoryProduct = 8, StorageCapacityProduct = 256, PriceProduct = 850000, ResolutionImageProduct = "2500x800", CategoryId = 2 });

            products.Add(new ProductModel { IdProduct = 7, NameProduct = "HP", DescriptionProduct = "HP 245 G7", ImageUrlProduct= "https://redecdecolombia.com/wp-content/uploads/2020/08/HP-245-G7-.jpg", MemoryProduct = 8, StorageCapacityProduct = 1000, PriceProduct = 1850000, ResolutionImageProduct = "1200x720", CategoryId = 3 });
            products.Add(new ProductModel { IdProduct = 8, NameProduct = "Acer", DescriptionProduct = "Acer AN515-54-58WV", ImageUrlProduct= "https://www.ktronix.com/medias/4710180926668-001-750Wx750H?context=bWFzdGVyfGltYWdlc3w0MDY0NjZ8aW1hZ2UvcG5nfGltYWdlcy9oYzgvaDlkLzEwMDMyMjgwMDc2MzE4LnBuZ3w4ODliM2E4Mzk2OWM0MDgxMTQ4ODJiZGNjODgyNDI2MDljMDE3NzgxMjhjM2ZmMjEwNTQ0NGUyMzZmZDY0YWFh", MemoryProduct = 12, StorageCapacityProduct = 1000, PriceProduct = 2550000, ResolutionImageProduct = "1366x768", CategoryId = 3 });
            products.Add(new ProductModel { IdProduct = 9, NameProduct = "Lenovo", DescriptionProduct = "Yoga c740", ImageUrlProduct= "https://www.pcworld.es/cmsdata/reviews/3783451/lenovo_yoga_c740_review_3_thumb1200_16-9.jpg", MemoryProduct = 10, StorageCapacityProduct = 256, PriceProduct = 3550000, ResolutionImageProduct = "1500x900", CategoryId = 3 });

            return products;
        }
    }
}
