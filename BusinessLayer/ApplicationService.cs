using PracticalProject.DataLayer.Entities;
using PracticalProject.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIndMeARoomatate.DataLayer.Repositories;

namespace PracticalProject.BusinessLayer
{
    public class ApplicationService
    {
        public void MakeApplication(string email, string title)
        {
            Console.WriteLine("Application made.");
            var application = new Application();
            
            var studentRepository = new StudentRepository();

            var allsStudents = studentRepository.GetAllStudent();

            var student = allsStudents
                .Where(p => p.Email.Equals(email, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();

            if (student == null)
            {

                Console.WriteLine("Email does not exist!");
                throw new Exception("Email does not exist!");
            }
            else
            {
                application.StudentID = student.Id;
            }
            
            var announcementRepo = new AnnouncementRepository();

            var allAnnouncements = announcementRepo.GetAllAnnouncement();

            var announcements = allAnnouncements
                .Where(t => t.Title.Equals(title, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();

            if (announcements == null)
            {
                Console.WriteLine("Announcement not found!");
                throw new Exception("Announcement not found!");
            }
            else
            {
                application.AnnouncementID = announcements.ID;
            }

            application.Status = "new";
            application.ApplicationDate = DateTime.Now;


            var applicationRepository = new ApplicationRepository();
            applicationRepository.AddApplication(application);


        }
    }
}
