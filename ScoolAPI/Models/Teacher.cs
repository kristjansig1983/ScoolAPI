using System.ComponentModel.DataAnnotations;

namespace ScoolAPI.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        [MaxLength(255)]
        public string LastName { get; set; }
    }
}
