using NguyenDuyNam_lab456.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NguyenDuyNam_lab456.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDatetime()
        {
            return DateTime.Parse(string.Format("{0}{1}", Date, Time));
        }
    }
}