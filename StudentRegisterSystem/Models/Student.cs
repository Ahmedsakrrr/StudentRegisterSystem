using System.ComponentModel.DataAnnotations;

namespace StudentRegisterSystem.Models
{
    //students(id, first_name, last_name, date_of_birth, email, phone_number, enrollment_date)
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string StudentCode { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime EnrollmentDate { get; set; }
    }
}
