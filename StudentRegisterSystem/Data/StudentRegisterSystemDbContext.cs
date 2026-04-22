using StudentRegisterSystem.Models;
namespace StudentRegisterSystem.Data
{
    public class StudentRegisterSystemDbContext:DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=StudentRegisterSystemDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorStudentAssignment> DoctorStudentAssignments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
