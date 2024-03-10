using Microsoft.EntityFrameworkCore;
using PracticalProject.Data.FindMeARoommateDb;
using PracticalProject.DataLayer.Entities;

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


        public Student GetById(int StudentID)
        {
            return _context.Students.Find(StudentID);
        }

        public void AddStudent(Student student)
        {
            foreach (var el in _context.Students)
            {
                if (el.Name == student.Name || el.Email == student.Email)
                {
                    throw new Exception("Name or email is already registered.");
                }
            }
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public List<Student> GetAllStudent()
        {
            var context = new FindMeARoommateDb();
            var students = context.Students.ToList();
            return students;
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
                _context.SaveChanges();
            }

        }
    }

    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student GetById(int StudentID);
        void AddStudent(Student Student);
        void Update(Student Student);
        void Delete(int ID);
    }
}
