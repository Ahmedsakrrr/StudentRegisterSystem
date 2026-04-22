namespace StudentRegisterSystem.Models
{
    
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public string CourseCode { get; set; } = string.Empty;
        public int Credits { get; set; }
    }
}
