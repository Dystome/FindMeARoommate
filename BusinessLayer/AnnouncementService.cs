using FIndMeARoomatate.DataLayer.Repositories;
using PracticalProject.Data.FindMeARoommateDb;
using PracticalProject.DataLayer.Entities;
using PracticalProject.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalProject.BusinessLayer
{

    public class AnnouncementService
    {
        public void MakeAnnouncement(string email)
        {
            Console.WriteLine("Make an Announcement.");
            var announcement = new Announcement();

            Console.WriteLine("Enter Title:");
            announcement.Title = Console.ReadLine();

            Console.WriteLine("Enter Description:");
            announcement.Description = Console.ReadLine();

            announcement.PublishedDate = DateTime.Now;

            announcement.IsActive = true;



            //Filter through emails to find student Id.
            var studentRepository = new StudentRepository();

            var allsStudents = studentRepository.GetAllStudent();

            var student = allsStudents
                .Where(p => p.Email.Equals(email, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();

            if(student == null)
            {
                Console.WriteLine("Email doesn't exist!");
                throw new Exception("Email doesn't exist");
            }
            else
            {
                announcement.StudentID = student.Id; //ID found by search;
            }

            //Add Announcement
            var announcementRepository = new AnnouncementRepository();
            announcementRepository.AddAnnouncement(announcement);
        }


        // Get All Announcements for a certain email;
        public List<Announcement> GetMyAnnouncement(string emails)
        {
            var studentRepository = new StudentRepository();

            var allsStudents = studentRepository.GetAllStudent();

            var student = allsStudents
                .Where(p => p.Email.Equals(emails, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();

            if (student == null)
            {
                Console.WriteLine("Email does not exist!");
                throw new Exception("Student does not exist!");
            }
            else
            {
                int id = student.Id;
                var announcementRepository = new AnnouncementRepository();
                var announcements = announcementRepository.GetAllAnnouncement()
                    .Where(x => x.StudentID == id)
                    .ToList();
                
                return announcements;
            }

        }

    }
}
