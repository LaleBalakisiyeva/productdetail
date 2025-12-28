using Microsoft.AspNetCore.Mvc;
using front_to_back.Models;
using front_to_back.ViewModels;
using front_to_back.DAL;
using Microsoft.EntityFrameworkCore;

namespace front_to_back.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
         public async Task<IActionResult> Index()

        
        {
            //        List<Slide> slides = new List<Slide>()
            //        {
            //           new Slide
            //           {

            //               Title = "Rose",
            //               Discount = 10,
            //               Description = "The rose is a decorative and fragrant plant widely used in gardens and parks.",
            //               Image = "1-1-524x617.png",
            //                Order = 2
            //           },
            //           new Slide
            //           {

            //                Title = "Aloe Vera",
            //                Discount = 15,
            //                Description = "Aloe Vera is a medicinal plant known for its healing properties and easy indoor care.",
            //                Image = "1-2-524x617.png",
            //                Order = 3
            //            },
            //           new Slide
            //           {

            //               Title = "Ficus",
            //               Discount = 5,
            //               Description = "Ficus is a popular indoor plant that helps improve air quality.",
            //               Image = "1-1-524x617.png",
            //               Order = 1
            //}
            //            };

            //        _context.Sliders.AddRange(slides);
            //        _context.SaveChanges();

            //        List<Category> categories = new List<Category>
            //        {
            //        new Category { Name = "Indoor Plants" },
            //         new Category {  Name = "Outdoor Plants" },
            //         new Category {  Name = "Succulents" },
            //         new Category {  Name = "Flowering Plants" },
            //         new Category {  Name = "Herbs" },
            //         new Category {  Name = "Trees" },
            //         new Category {  Name = "Shrubs" },
            //         new Category {  Name = "Medicinal Plants" }
            //        };

            //        _context.Categories.AddRange(categories);
            //        _context.SaveChanges();


            //var categories = _context.Categories.ToList();
//            List<Product> products = new List<Product>
//{
//    new Product
//    {
//        Name = "Aloe Vera",
//        Description = "Medicinal indoor plant known for its healing properties",
//        Price = 12.50m,
//        SKU = "PLT-ALOE-001",
//        CategoryId =1
//    },
//    new Product
//    {
//        Name = "Snake Plant",
//        Description = "Low maintenance indoor plant that purifies air",
//        Price = 18.00m,
//        SKU = "PLT-SNAKE-002",
//        CategoryId = 2
//    },
//    new Product
//    {
//        Name = "Peace Lily",
//        Description = "Elegant flowering plant suitable for home and office",
//        Price = 22.75m,
//        SKU = "PLT-LILY-003",
//        CategoryId = 3
//    },
//    new Product
//    {
//        Name = "Monstera Deliciosa",
//        Description = "Popular tropical plant with large decorative leaves",
//        Price = 35.00m,
//        SKU = "PLT-MONSTERA-004",
//        CategoryId = 4
//    },
//    new Product
//    {
//        Name = "Fiddle Leaf Fig",
//        Description = "Tall indoor plant with broad glossy leaves",
//        Price = 45.90m,
//        SKU = "PLT-FIDDLE-005",
//        CategoryId = 5
//    },
//    new Product
//    {
//        Name = "Cactus Mix",
//        Description = "Set of small cactus plants for desks and shelves",
//        Price = 15.30m,
//        SKU = "PLT-CACTUS-006",
//        CategoryId = 6
//    },
//    new Product
//    {
//        Name = "Lavender Plant",
//        Description = "Fragrant plant known for its calming scent",
//        Price = 19.99m,
//        SKU = "PLT-LAVENDER-007",
//        CategoryId = 7
//    },
//    new Product
//    {
//        Name = "Bonsai Tree",
//        Description = "Miniature tree cultivated for decoration and relaxation",
//        Price = 60.00m,
//        SKU = "PLT-BONSAI-008",
//        CategoryId = 8
//    }
//};

            //_context.Products.AddRange(products);
            //_context.SaveChanges();

//            List<Blog> blogs = new List<Blog>()
//            {
//               new Blog
//               {

//                  Title = "The Beauty of Indoor Plants",
//                  Description = "Indoor plants improve air quality and create a calm, natural atmosphere at home.",
//                  Image = "1-1-310x220.jpg",
//                  Date = new DateTime(2025, 1, 10),
//                  Author = "Admin"
//               },
//               new Blog
//               {

//                   Title = "How to Take Care of Orchids",
//                   Description = "Orchids need proper light, watering, and humidity to bloom beautifully.",
//                   Image = "1-1-310x220.jpg",
//                   Date = new DateTime(2025, 2, 5),
//                  Author = "Flora Expert"
//               },
//             new Blog
//             {

//                 Title = "Benefits of Having Plants at Work",
//                 Description = "Office plants reduce stress and increase productivity in the workplace.",
//                  Image = "1-1-310x220.jpg",
//                 Date = new DateTime(2025, 3, 1),
//                Author = "Green Life"
//             }
//};
            //_context.Blogs.AddRange(blogs);
            //_context.SaveChanges();

            //var products
//            List<ProductImage> productImages = new List<ProductImage>()
//{
//            new ProductImage
//            {
//              Image = "1-2-270x300.jpg",
//             ProductId = 7,
//             IsPrimary = true
//            },
//             new ProductImage
//             {
//               Image = "1-10-270x300.jpg",
//               ProductId = 8,
//               IsPrimary = false
//             },
//             new ProductImage
//             {
//              Image = "1-11-270x300.jpg",
//              ProductId = 9,
//               IsPrimary = null
//             },
//             new ProductImage
//             {
//               Image = "1-2-270x300.jpg",
//               ProductId = 10,
//               IsPrimary = true
//             },
//             new ProductImage
//             {
//               Image = "1-10-270x300.jpg",
//               ProductId = 11,
//               IsPrimary = false
//             },
//            new ProductImage
//            {
//               Image = "1-11-270x300.jpg",
//               ProductId = 12,
//               IsPrimary = null
//            },
//            new ProductImage
//            {
//              Image = "1-2-270x300.jpg",
//              ProductId = 13,
//              IsPrimary = true
//             },

//           };
            //_context.ProductImages.AddRange(productImages);
            //_context.SaveChanges();

            //_context.Sliders.AddRange(slides);
            //_context.SaveChanges();

            //_context.Blogs.AddRange(blogs);
            //_context.SaveChanges();

            //_context.Products.AddRange(products);
            //_context.SaveChanges();

            //_context.Categories.AddRange(categories);
            //_context.SaveChanges();

            //_context.ProductImages.AddRange(productImages);
            //_context.SaveChanges();



            HomeVM homeVM = new HomeVM
            {
               Slides = await _context.Sliders.OrderBy(s => s.Order).Take(2).ToListAsync(),
               Products =await _context.Products.Include(p=>p.ProductImages).Include(p => p.Category).ToListAsync(),
               Blogs = await _context.Blogs.ToListAsync()
            };
            return View(homeVM);
        }
    }
}

