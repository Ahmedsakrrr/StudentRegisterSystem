namespace StudentRegisterSystem.Models
{
    //doctor_student_assignments(id, doctor_id, student_id, assignment_date)
    [PrimaryKey(nameof(StudentId), nameof(DoctorId))]
    public class DoctorStudentAssignment
    {
        public string DoctorStudentAssignmentCode { get; set; }=string.Empty;
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime AssignmentDate { get; set; }
    }
}
