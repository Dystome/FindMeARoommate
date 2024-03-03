using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalProject.DataLayer.Entities
{
    public class Announcement
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedDate { get; set; }
        [ForeignKey("AnnouncementOwner")]
        [Required]
        public int StudentID { get; set; }
        public Student AnnouncementOwner { get; set; }
        public bool IsActive { get; set; }
        public bool IsSameGender { get; set; }

    }
}
