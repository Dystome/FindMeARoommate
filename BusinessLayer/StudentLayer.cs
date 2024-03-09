using PracticalProject.DataLayer.Entities;
using PracticalProject.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        //Student Business Logic
        #endregion
    }
}
