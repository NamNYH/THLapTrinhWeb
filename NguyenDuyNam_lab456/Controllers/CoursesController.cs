
using NguyenDuyNam_lab456.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenDuyNam_lab456.Controllers
{
    public class CoursesController : Controller
    {
        private readonly Models.ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new Models.ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var ViewModel = new CourseViewModels
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(ViewModel);
        }
    }
}