using Microsoft.AspNetCore.Mvc;
using dotNetCoreEntityFramework.Data;
using dotNetCoreEntityFramework.Domain;
using System.Linq;

namespace dotNetCoreEntityFramework.Controllers
{
    public class CategoryController: Controller
    {
        private readonly ApplicationDBContext _context;

        public CategoryController(ApplicationDBContext context)
        {
            _context = context;
            
        }

        public IActionResult Index(int id){

            var categories = _context.Categories.ToList();
            ViewBag.Categories = categories;

            var categorySelected = _context.Categories.FirstOrDefault(c => c.Id == id);

            return View(categorySelected);
        }

        [HttpPost]
        public IActionResult Register(Category category){

            if(category.Id == 0)
            {
                _context.Categories.Add(category);
            }else{
                var categorySaved = _context.Categories.FirstOrDefault(c => c.Id == category.Id);
                categorySaved.Name = category.Name;
                _context.Categories.Update(categorySaved);
            }
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {

            var categorySelected = _context.Categories.FirstOrDefault(c => c.Id == id);
            _context.Categories.Remove(categorySelected);
            _context.SaveChanges();
            
            return RedirectToAction("Index");
        }


    }
}