using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScoolAPI.Data;
using ScoolAPI.Models;
using ScoolAPI.Controllers;
using ScoolAPI.Data.Interfaces;

namespace ScoolAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private ISchoolRepository _repo;

        public SchoolController(ISchoolRepository repo) // Dependancy Injection

        


        {
            _repo = repo;
            
        }

        [HttpGet]
        [Route("teachers")]
        public List<Teacher> GetAllTeachers()
        {
            return _repo.GetAllTeachers();
        }

        [HttpGet]
        [Route("teachers/{id}")]
        public ActionResult<Teacher> GetTeacherById(int id)
        {
            
            Teacher? teacher = _repo.GetTeacherById(id);

            if (teacher == null)
            {
                return NotFound();
            }
            return teacher;
            
        }
        [HttpGet]
        [Route("students")]
        public List<Student> GetAllStudents()
        {
            return _repo.GetAllStudents();
        }

    }
}
