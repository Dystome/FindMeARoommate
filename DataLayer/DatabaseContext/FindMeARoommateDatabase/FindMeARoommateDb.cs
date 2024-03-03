using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PracticalProject.DataLayer.Entities;
using PracticalProject.DataLayer.Repositories;
namespace PracticalProject.Data.FindMeARoommateDb;

public class FindMeARoommateDb : DbContext
{
    public FindMeARoommateDb() { }
    public DbSet<Student> Students { get; set; }

    public DbSet<Announcement> Announcements { get; set; }
    public DbSet<Application> Applications { get; set; }
    public DbSet<Dormitory> Dormitories { get; set; }
    public DbSet<StudentDormitory> StudentDormitories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-K9CBNB1\\SQLEXPRESS;Initial Catalog=FindMeARoommateDb;Integrated Security=True;Trust Server Certificate=True");
        
    }



}


