namespace TechnologyWebStore.Models
{
    public class ProductModel
    {
        public int IdProduct { get; set; }
        public string NameProduct { get; set; }
        public string DescriptionProduct { get; set; }
        public string ImageUrlProduct { get; set; }
        public int MemoryProduct { get; set; }
        public int StorageCapacityProduct { get; set; }
        public string ResolutionImageProduct { get; set; }
        public double PriceProduct { get; set; }
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
    }
}
