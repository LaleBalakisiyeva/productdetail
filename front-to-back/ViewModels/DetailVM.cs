using front_to_back.Models;

namespace front_to_back.ViewModels
{
    public class DetailVM
    {
        public Product Product { get; set; }

        public List<Product> RelatedProducts { get; set; }
    }
}
