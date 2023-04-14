using Microsoft.AspNetCore.Mvc;
using ScoolAPI.Models;
using ScoolAPI.Data.Interfaces;

namespace ScoolAPI.Data
{
    public class MockRepository : ISchoolRepository
    {
        List<Teacher> Teachers = new List<Teacher>() {
        new Teacher() { TeacherId = 1, FirstName = "Hjörtur", LastName = "Pálmi"},
        new Teacher() { TeacherId = 1, FirstName = "Adam", LastName = "Hart"},
        new Teacher() { TeacherId = 1, FirstName = "Skúli", LastName = "Gunnsteinsson"},
        new Teacher() { TeacherId = 1, FirstName = "Björgvin", LastName = "Páll"},
    };

        List<Student> Students = new List<Student>() { new Student() { StudentId = 1, FirstName = "Mock", LastName = "Mockson" } };

        public List<Teacher> GetAllTeachers()
        {
            return Teachers;
        }

        public List<Student> GetAllStudents()
        {
            return Students;
        }

        public Teacher? GetTeacherById(int id)
        {

            foreach (Teacher teacher in Teachers)
            {
                if (teacher.TeacherId == id)
                {
                    return teacher;
                }
            }
            return null;
        }

    }
}
