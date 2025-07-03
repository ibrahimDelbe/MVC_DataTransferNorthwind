using Microsoft.AspNetCore.Mvc;
using MVC_DataTransferNorthwind.Models.Northwind;

namespace MVC_DataTransferNorthwind.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindContext _context = new NorthwindContext();




        //Get
        NorthwindContext context = new NorthwindContext();
        public IActionResult Index( Category category)

             
        {
            ViewBag.Categories = context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            try
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                TempData["Success"] = "Kategori oluşturuldu!";
            }
            catch (Exception ex)
            {

                TempData["Error"] = ex.Message;
            }
            return View();

        }
    }
}
