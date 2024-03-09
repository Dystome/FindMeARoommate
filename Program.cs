using PracticalProject.BusinessLayer;
using PracticalProject.Data.FindMeARoommateDb;
using PracticalProject.DataLayer.Entities;
using PracticalProject.DataLayer.Repositories;
using System.Timers;


Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Menu");
Console.WriteLine("1 - Register");
Console.WriteLine("2 - Login");
Console.WriteLine("3 - Get All students");
Console.WriteLine("4 - Get My Profile");
Console.WriteLine("5 - Make a new Announcement");
Console.WriteLine("6 - Get all my announcements");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        {
            //Register
            var studentService = new StudentService();
            studentService.RegisterStudent();

            break;
        }
    case 2:
        {
            //Login
            Console.WriteLine("Enter Email");
            var Email = Console.ReadLine();

            Console.WriteLine("Enter Password");
            var Password = Console.ReadLine();

            var studentService = new StudentService();
            studentService.LoginStudent(Email, Password);
            break;
        }
    case 3:
        {
            //Print all students
            var studentService = new StudentService();
            var student = studentService.GetStudents();
            foreach(var el in student)
            {
                Console.WriteLine(el.Name + " " + el.Surname + " " + el.Address );
            }
            break;

        }
    case 4: 
        {
            //Get my profile
            Console.WriteLine("Enter email:");
            var email = Console.ReadLine();

            var studentService = new StudentService();
            studentService.GetMyProfile(email);

            break;

        }

    case 5:
        {
            //Make a new announcement
            Console.WriteLine("Enter email:");
            var email = Console.ReadLine();

            var announcementService = new AnnouncementService();
            announcementService.MakeAnnouncement(email);

            break;
        }

    case 6:
        {
            //See all my announcements
            Console.WriteLine("Enter email:");
            var email = Console.ReadLine();
            var announcementService = new AnnouncementService();
            var announcements = announcementService.GetMyAnnouncement(email);
            
            foreach(var el in announcements)
            {
                Console.WriteLine(el.Title + "\n" + el.Description);
            }

            break;
        }
}

Console.WriteLine("--------------------------------------------------");