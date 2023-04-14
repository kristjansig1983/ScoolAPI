namespace ScoolAPI.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Title { get; set; }
        public List<Teacher> Teachers { get; set; } = new();

    }
}
