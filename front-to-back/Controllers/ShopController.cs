using front_to_back.DAL;
using front_to_back.Models;
using front_to_back.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace front_to_back.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult > Detail(int? id)
        {
            if (id == null || id < 1)
            {
                return BadRequest();
            }
        
            Product product= await _context.Products.Include(p=>p.ProductImages).Include(p=>p.Category).FirstOrDefaultAsync(p => p.Id == id);

            if (product==null)
            {
                return NotFound();
            }


            List<Product> relatedProducts = _context.Products.Include(p => p.ProductImages).Include(p => p.Category).Where(p => p.CategoryId == product.CategoryId).ToList();
            DetailVM detailVM = new DetailVM
            {
                Product = product,
                RelatedProducts=relatedProducts
            };
            return View(detailVM);

           
        }
    }
}
