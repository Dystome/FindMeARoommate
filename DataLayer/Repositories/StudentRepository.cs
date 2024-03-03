using Microsoft.EntityFrameworkCore;
using PracticalProject.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticalProject.Data.FindMeARoommateDb;

namespace PracticalProject.DataLayer.Repositories
{
    public class StudentRepository : IStudentRepository
    {

        public readonly FindMeARoommateDb _context;

        public StudentRepository()
        {
            _context = new FindMeARoommateDb();
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int StudentID) => _context.Students.Find(StudentID);

        public void Insert(Student Student)
        {
            _context.Students.Add(Student);
        }
     
        public void Update(Student Student)
        {
           
            _context.Entry(Student).State = EntityState.Modified;
        }
 
        public void Delete(int StudentID)
        {
         
            Student Student = _context.Students.Find(StudentID);
            if (Student != null)
            {
                _context.Students.Remove(Student);
            }

        }
    }

    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student GetById(int StudentID);
        void Insert(Student Student);
        void Update(Student Student);
        void Delete(int ID);
    }
}
