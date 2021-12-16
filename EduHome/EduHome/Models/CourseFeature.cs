using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class CourseFeature
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Duration { get; set; }
        public DateTime ClassDuration { get; set; }
        [MaxLength(30)]
        public string SkilLevel { get; set; }
        [Column(TypeName= "smallint")]
        public int Student { get; set; }
        [MaxLength(50)]
        public string Languages { get; set; }
        [MaxLength(20)]
        public string Assesments { get; set; }
        public int Paid { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
