namespace StudentRegisterSystem.Models
{
    [PrimaryKey(nameof(StudentId), nameof(CourseId))]
    public class Enrollment
    {
        public string  EnrollmentCode { get; set; }=string.Empty;
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
