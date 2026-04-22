using System.ComponentModel.DataAnnotations;

namespace StudentRegisterSystem.Models
{
    //doctors(id, first_name, last_name, specialty, email, phone_number, hire_date)
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Specialty { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateOnly HireDate { get; set; }
    }
}
