using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Speaker
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string FullName { get; set; }
        [MaxLength(50)]
        public string Position { get; set; }
        [MaxLength(250)]
        public string SpeakerImage { get; set; }
        [NotMapped]
        public IFormFile SpeakerImageFile { get; set; }
       public  List<SpekerToEvent> SpekerToEvents { get; set; }

    }
}
