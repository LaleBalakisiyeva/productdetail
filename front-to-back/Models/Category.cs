using front_to_back.Models.Base;

namespace front_to_back.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
       
        public List<Product> Products { get; set; }
    }
}
