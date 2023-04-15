using Microsoft.AspNetCore.Mvc;
using ScoolAPI.Models;

// Samningur þannig að það sé auðveldara að fara á milli production og test gagnagrunni (School og MockRepository)

namespace ScoolAPI.Data.Interfaces
{
    public interface ISchoolRepository
    {

        List<Teacher> GetAllTeachers();
        List<Student> GetAllStudents();
        Teacher? GetTeacherById(int id);

        void CreateTeacher(Teacher teacher);

        Teacher? UpdateTeacher(int id, Teacher teacherFromBody);
        bool DeleteTeacher(Teacher teacher);
    }
}
