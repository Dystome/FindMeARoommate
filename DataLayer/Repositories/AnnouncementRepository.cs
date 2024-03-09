using PracticalProject.Data.FindMeARoommateDb;
using PracticalProject.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIndMeARoomatate.DataLayer.Repositories
{
    public class AnnouncementRepository
    {
        public void AddAnnouncement(Announcement student)
        { // DbContext Add Method
            var dbContext = new FindMeARoommateDb();
            dbContext.Announcements.Add(student);
            dbContext.SaveChanges();
        }

        // Get All Student
        public List<Student> GetAllStudent()
        {
            var context = new FindMeARoommateDb();
            var students = context.Students.ToList();

            return students;
        }
        // Get By ID
        public Student FindByID(int id)
        {
            try
            {
                var dbContext = new FindMeARoommateDb();
                var student = dbContext.Students.Where(p => p.Id == id)
                    .FirstOrDefault();
                return student;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        //Update
        //Remove
        public void DeleteStudent(Student student)
        {
            try
            {
                var dbContext = new FindMeARoommateDb();
                dbContext.Students.Remove(student);
                dbContext.SaveChanges();
                Console.WriteLine("Student removed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message.ToString());
                throw ex;
            }
        }
        public void UpdateStudent(Student student)
        {
            try
            {
                var dbContext = new FindMeARoommateDb();
                dbContext.Students.Update(student);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}