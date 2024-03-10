using PracticalProject.Data.FindMeARoommateDb;
using PracticalProject.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalProject.DataLayer.Repositories
{
    public class ApplicationRepository
    {
        public void AddApplication(Application application)
        { // DbContext Add Method
            var dbContext = new FindMeARoommateDb();
            dbContext.Applications.Add(application);
            dbContext.SaveChanges();
        }

        public List<Application> GetAllApplication()
        {
            var context = new FindMeARoommateDb();
            var application = context.Applications.ToList();
            return application;
        }

        public Application FindByID(int id)
        {
            try
            {
                var dbContext = new FindMeARoommateDb();
                var application = dbContext.Applications
                    .Where(p => p.ID == id)
                    .FirstOrDefault();
                return application;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        //Remove
        public void DeleteApplication(Application Application)
        {
            try
            {
                var dbContext = new FindMeARoommateDb();
                dbContext.Applications.Remove(Application);
                dbContext.SaveChanges();
                Console.WriteLine("Application removed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message.ToString());
                throw ex;
            }
        }

        //Update
        public void UpdateApplication(Application Application)
        {
            try
            {
                var dbContext = new FindMeARoommateDb();
                dbContext.Applications.Update(Application);
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
