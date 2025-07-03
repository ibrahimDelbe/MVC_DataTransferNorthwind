using Microsoft.AspNetCore.Mvc;
using MVC_DataTransferNorthwind.Models.Northwind;

namespace MVC_DataTransferNorthwind.Controllers
{
    public class ProductController : Controller
    {
        NorthwindContext _context = new NorthwindContext();


        NorthwindContext context = new NorthwindContext();

        public IActionResult Index()
        {
            //Categories
           
            ViewBag.Products = context.Products.ToList();

            //Products
            return View();
        }



        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                TempData["Success"] = "Ürün Oluşturuldu!";
            }
            catch (Exception ex)
            {

                TempData["Error"] = ex.Message;
            }
            return View();
        }
    }
}
