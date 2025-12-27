using front_to_back.Models.Base;

namespace front_to_back.Models
{
    public class Product:BaseEntity
    {
        
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }

        public string SKU { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<ProductImage> ProductImages { get; set; }

    }
}
