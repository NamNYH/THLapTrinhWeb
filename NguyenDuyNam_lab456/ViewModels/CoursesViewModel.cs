using NguyenDuyNam_lab456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenDuyNam_lab456.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Courses> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
        ublic string Date { get; internal set; }
        public List<Category> Categories { get; internal set; }
        public byte Category { get; internal set; }
        public string Place { get; internal set; }
        public string Time { get; internal set; }
    }
}
