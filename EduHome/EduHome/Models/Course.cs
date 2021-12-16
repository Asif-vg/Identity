using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(250)]
        public string CourseImage { get; set; }
        [NotMapped]
        public IFormFile CourseImageFile { get; set; }
        public List<CourseToCategory> CourseToCategories { get; set; }
        public List<CourseComment> CourseComments { get; set; }
        public List<AboutCourse> AboutCourses { get; set; }
        public List<CourseFeature> CourseFeatures { get; set; }
        public List<TagToCourse> TagToCourse { get; set; }











    }
}
