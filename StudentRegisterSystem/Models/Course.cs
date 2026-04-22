namespace StudentRegisterSystem.Models
{
    //courses(id, course_name, course_code, credits)
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public string CourseCode { get; set; } = string.Empty;
        public int Credits { get; set; }
    }
}
