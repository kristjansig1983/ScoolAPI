using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using ScoolAPI.Data.Interfaces;


// Data transfer object, notað til að fá fram einungis þær upplýsingar sem þú vilt. Breitir því í fyrirspurn í modeli sem á við.
namespace ScoolAPI.Models
{
    public class TeacherDTO
    {
        
        public string FirstName { get; set; }
        [MaxLength(255)]
        
        public List<Subject> Subjects { get; set; } = new();

        
    }
}
