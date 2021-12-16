using EduHome.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions option):base(option)
        {
                
        }
        public DbSet<AboutCourse> AboutCourses { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategorys { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCategory> CourseCategorys { get; set; }
        public DbSet<CourseComment> CourseComments { get; set; }
        public DbSet<CourseFeature> CourseFeatures { get; set; }
        public DbSet<CourseToCategory> CourseToCategorys { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventComment> EventComments { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<SpekerToEvent> SpekerToEvents { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagToBlog> TagToBlogs { get; set; }
        public DbSet<TagToCourse> TagToCourses { get; set; }



    }
}
