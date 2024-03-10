using PracticalProject.DataLayer.Entities;
using PracticalProject.DataLayer.Repositories;
using System.Security.Cryptography;
using System.Timers;

namespace PracticalProject.BusinessLayer
{
    public class StudentService
    {
        #region Business Layer
        //Student Business Logic
        //Get All students
        public List<Student> GetStudents()
        {
            var studentRepo = new StudentRepository();
            var students = studentRepo.GetAllStudent();
            return students;
        }
        //Register Student
        public void RegisterStudent()
        {
            Console.WriteLine("Register");
            var student = new Student();
            Console.WriteLine("Enter Name");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter Surname");
            student.Surname = Console.ReadLine();
            Console.WriteLine("Enter Address");
            student.Address = Console.ReadLine();
            Console.WriteLine("Enter Gender");
            student.Gender = Console.ReadLine();
            Console.WriteLine("Enter Email");
            student.Email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            student.Password = Console.ReadLine();
            //Add student
            var studentRepository = new StudentRepository();
            studentRepository.AddStudent(student);
        }

        //Log in
        public void LoginStudent(string email, string password)
        {
            Console.WriteLine("Enter email:");
            var studentRepository = new StudentRepository();

            var allsStudents = studentRepository.GetAllStudent();

            var student = allsStudents
                .Where(p => p.Email.Equals(email, StringComparison.CurrentCultureIgnoreCase) 
                && p.Password == password)
                .FirstOrDefault();

            //Check results
            if(student == null)
            {
                Console.WriteLine("Invalid Login!");
                throw new Exception("Invalid Cresentials!"); //Throws exception, wrong credentials
            }

            Console.WriteLine("Login Successful!");
            
        }

        public void GetMyProfile(string emails)
        {
            var studentRepository = new StudentRepository();

            var allsStudents = studentRepository.GetAllStudent();

            var student = allsStudents
                .Where(p => p.Email.Equals(emails, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();


            if(student == null) //Checks for email if it exists
            {
                Console.WriteLine("Email does not exist in database.");
                throw new Exception("Email does not exist!");
            } 

            Console.WriteLine(student.Name + " " + student.Surname + " " + student.Address);

        }
        //Student Business Logic
        #endregion
    }
}
