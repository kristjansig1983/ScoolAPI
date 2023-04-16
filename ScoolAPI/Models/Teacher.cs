using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using ScoolAPI.Data.Interfaces;

namespace ScoolAPI.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        [MaxLength(255)]
        public string LastName { get; set; }
        public List<Subject> Subjects { get; set; } = new();

       // public string ProfileImGurl  { get; set; } // = url fyrir mynd.



    }
}
