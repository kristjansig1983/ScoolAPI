using ScoolAPI.Data.Interfaces;
using ScoolAPI.Models;
using System.Runtime.CompilerServices;


namespace ScoolAPI.Data
{
    public class SchoolRepository : ISchoolRepository
    {

        private SchoolDBContext _dbContext;
        public SchoolRepository()
        {
            _dbContext = new SchoolDBContext();
        }

        public List<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public List<Teacher> GetAllTeachers()
        {
            return _dbContext.Teachers.ToList();
        }

        public Teacher? GetTeacherById(int id)
        {
            return _dbContext.Teachers.Where(t => t.TeacherId ==  id).FirstOrDefault();
        }
    }
}
