namespace StudentRegisterSystem.Models
{
    //enrollments(id, student_id, course_id, enrollment_date)
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
