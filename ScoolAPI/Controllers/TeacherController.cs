using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScoolAPI.Data;
using ScoolAPI.Models;

namespace ScoolAPI.Controllers
{
    [Route("api/teachers")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private MockRepository _repo;

        public TeacherController()
        {
            _repo = new MockRepository();
        }

        [HttpGet]
        public List<Teacher> GetAllTeachers()
        {
            return _repo.GetAllTeachers();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Teacher> GetTeacherById(int id)
        {
            
            Teacher? teacher = _repo.GetTeacherById(id);

            if (teacher == null)
            {
                return NotFound();
            }
            return teacher;
            
        }
    }
}
