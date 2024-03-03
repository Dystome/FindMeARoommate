using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalProject.DataLayer.Entities
{
    public class StudentDormitory
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public Student Student { get; set; } //name of student must match with fk
        [ForeignKey("Dormitory")]
        public int DormitoryID { get; set; }
        public Dormitory Dormitory { get; set; }
    }
}
