using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class EventComment
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(250)]
        public string Subject { get; set; }
        [MaxLength(4000)]
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("Event")]
        public int EventId { get; set; }
        public Event Event { get; set; }
        [ForeignKey("EventComments")]
        public int CommentId { get; set; }
        public EventComment EventComments { get; set; }




    }
}
