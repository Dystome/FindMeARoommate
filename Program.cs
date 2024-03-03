using PracticalProject.Data.FindMeARoommateDb;
using PracticalProject.DataLayer.Entities;

var context = new FindMeARoommateDb();
var users = context.Students.ToList();


foreach (var user in users)
{
    Console.WriteLine(user.Name + " " + user.Surname + " " + user.Address);
}

//s