using System.Linq;
using System.Web.Mvc;
using NguyenDuyNam_lab456.Models;
using NguyenDuyNam_lab456.ViewModels;
using Microsoft.AspNet.Identity;

namespace NguyenDuyNam_lab456.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var ViewModels = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(ViewModels);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseViewModel ViewModels)
        {
            if (!ModelState.IsValid)
            {
                ViewModels.Categories = _dbContext.Categories.ToList();
                return View("Create", ViewModels);
            }
            var course = new Courses
            {
                LectureredId = User.Identity.GetUserId(),
                DateTime = ViewModels.GetDatetime(),
                CategoryId = ViewModels.Category,
                Place = ViewModels.Place
           };
            _dbContext.Course.Add(course);
            _dbContext.SaveChanges();
            return RedirectToAction("Index","Home");
        }

    }
}