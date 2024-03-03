using PracticalProject.Data.FindMeARoommateDb;
using PracticalProject.DataLayer.Entities;
using PracticalProject.DataLayer.Repositories;


var rep = new StudentRepository();
var users = rep._context.Students.ToList();
foreach (var user in users)
{
    Console.WriteLine(user.Name + " " + user.Surname + " " + user.Address);
}
