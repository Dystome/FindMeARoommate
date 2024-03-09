using PracticalProject.Data.FindMeARoommateDb;
using PracticalProject.DataLayer.Entities;
using PracticalProject.DataLayer.Repositories;

namespace FIndMeARoomatate.DataLayer.Repositories
{
    public class AnnouncementRepository
    {
        //Create Announcement
        public void AddAnnouncement(Announcement student)
        { // DbContext Add Method
            var dbContext = new FindMeARoommateDb();
            dbContext.Announcements.Add(student);
            dbContext.SaveChanges();
        }

        public List<Announcement> GetAllAnnouncement()
        {
            var context = new FindMeARoommateDb();
            var announcement = context.Announcements.ToList();
            return announcement;
        }

        //Remove
        public void DeleteAnnouncement(Announcement announcement)
        {
            try
            {
                var dbContext = new FindMeARoommateDb();
                dbContext.Announcements.Remove(announcement);
                dbContext.SaveChanges();
                Console.WriteLine("Announcement removed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message.ToString());
                throw ex;
            }
        }

        //Update
        public void UpdateStudent(Announcement announcement)
        {
            try
            {
                var dbContext = new FindMeARoommateDb();
                dbContext.Announcements.Update(announcement);
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