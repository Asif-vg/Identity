using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }
        [Column(TypeName= "ntext")]
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(250)]
        public string EventImage { get; set; }
        [NotMapped]
        public IFormFile EventImageFile { get; set; }
        public List<SpekerToEvent> SpekerToEvents { get; set; }
        public List<EventComment> EventComments { get; set; }






    }
}
