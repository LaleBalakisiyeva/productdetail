using front_to_back.Models;
namespace front_to_back.ViewModels
{
    public class HomeVM
    {
        public List<Slide> Slides { get; set; }

        public List<Product> Products { get; set; }

        public List<Blog> Blogs { get; set; }

        public List<Category> Categories { get; set; }

        public List<ProductImage> ProductImages { get; set; }
    }
}
