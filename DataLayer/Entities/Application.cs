using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalProject.DataLayer.Entities
{
    public class Application
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Announcement")]
        [Required]
        public int AnnouncementID { get; set; }

        public Announcement Announcement { get; set; }

        [ForeignKey("Applicant")]
        [Required]
        public int StudentID { get; set; }

        public Student Applicant { get; set; }

        public string Status { get; set; }

        public DateTime? ApplicationDate { set; get; }

        public bool IsActive { get; set; }

    }
}
