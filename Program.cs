using PracticalProject.BusinessLayer;
using PracticalProject.Data.FindMeARoommateDb;
using PracticalProject.DataLayer.Entities;
using PracticalProject.DataLayer.Repositories;


Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Menu");
Console.WriteLine("1 - Register");
Console.WriteLine("2 - Get All students");
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
            //Print all students
            var studentService = new StudentService();
            var students = new List<Student>();
            students = studentService.GetStudents();

            break;
        }
}

Console.WriteLine("--------------------------------------------------");