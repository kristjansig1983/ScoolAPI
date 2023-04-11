using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ScoolAPI.Models
{
    [Route("api/teachers")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        [HttpGet]
        public List<Teacher> GetAllTeachers()
        {
            return new List<Teacher>() {
                new Teacher() { TeacherId = 1, FirstName = "Hjörtur", LastName = "Pálmi"},
                new Teacher() { TeacherId = 1, FirstName = "Adam", LastName = "Hart"},
                new Teacher() { TeacherId = 1, FirstName = "Skúli", LastName = "Gunnsteinsson"},
                new Teacher() { TeacherId = 1, FirstName = "Björgvin", LastName = "Páll"},
            };
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Teacher> GetTeacherById(int id)
        {
            List<Teacher> teachers = new List<Teacher>() {
                new Teacher() { TeacherId = 1, FirstName = "Hjörtur", LastName = "Pálmi"},
                new Teacher() { TeacherId = 2, FirstName = "Adam", LastName = "Hart"},
                new Teacher() { TeacherId = 3, FirstName = "Skúli", LastName = "Gunnsteinsson"},
                new Teacher() { TeacherId = 4, FirstName = "Björgvin", LastName = "Páll"},
            };
            foreach (Teacher teacher in teachers)
            {
                if (teacher.TeacherId == id)
                {
                    return teacher;
                }
            }
            return NotFound();
        }
    }
}
