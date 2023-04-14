namespace ScoolAPI.Models
{
    public class Student
    {
        public Student() 
        { 
            
        }
        public int StudentId { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
