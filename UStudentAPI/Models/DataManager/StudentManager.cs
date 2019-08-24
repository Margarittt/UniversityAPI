using System.Collections.Generic;
using System.Linq;
using UStudentAPI.Models.Repository;

namespace UStudentAPI.Models.DataManager
{
    public class StudentManager : IDataRepository<Student>
    {
        readonly StudentContext _studentContext;

        public StudentManager(StudentContext context)
        {
            _studentContext = context;
        }

        public IEnumerable<Student> GetAll()
        {
            return _studentContext.Students.ToList();
        }

        public Student Get(int id)
        {
            return _studentContext.Students.FirstOrDefault(e => e.StudentId == id);
        }

        public void Add(Student entity)
        {
            _studentContext.Students.Add(entity);
            _studentContext.SaveChanges();
        }

        public void Update(Student student, Student entity)
        {
            student.FirstName = entity.FirstName;
            student.LastName = entity.LastName;
            student.University = entity.University;
            student.City = entity.City;
            student.Country = entity.Country;
            _studentContext.SaveChanges();

            _studentContext.SaveChanges();
        }

        public void Delete(Student student)
        {
            _studentContext.Students.Remove(student);
            _studentContext.SaveChanges();
        }
    }
}
