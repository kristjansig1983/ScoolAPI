using Microsoft.AspNetCore.Mvc;
using ScoolAPI.Models;

namespace ScoolAPI.Data
{
    public class MockRepository
    {
        List<Teacher> Teachers = new List<Teacher>() {
        new Teacher() { TeacherId = 1, FirstName = "Hjörtur", LastName = "Pálmi"},
        new Teacher() { TeacherId = 1, FirstName = "Adam", LastName = "Hart"},
        new Teacher() { TeacherId = 1, FirstName = "Skúli", LastName = "Gunnsteinsson"},
        new Teacher() { TeacherId = 1, FirstName = "Björgvin", LastName = "Páll"},
    };

        public List<Teacher> GetAllTeachers()
        {
            return Teachers;
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
