using BulkyBookWeb.Data; //added so that private readonly ApplicationDbContext _db; could be used
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db; //private class _db using ApplicationDbContext

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories; //added to retrieve all categories from _db database Categories table and creating a List then assigning this all to the local var
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            
            return View();
        }


    }
}