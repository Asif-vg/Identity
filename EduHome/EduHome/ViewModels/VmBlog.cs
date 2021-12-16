using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class VmBlog :VmLayout
    {
        public Banner Banner { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<BlogCategory> BlogCategorys { get; set; }
        public List<Tag> Tags { get; set; }


    }
}
