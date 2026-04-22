using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentRegisterSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInTableCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Courses (CourseName, CourseCode, credits, DoctorId) values ('Introduction to Computer Science', 'CS101', 3, 1);insert into Courses (CourseName, CourseCode, credits, DoctorId) values ('Data Structures', 'CS201', 2, 1);insert into Courses (CourseName, CourseCode, credits, DoctorId) values ('Algorithms', 'CS301', 1, 1);insert into Courses (CourseName, CourseCode, credits, DoctorId) values ('Operating Systems', 'CS205', 3, 1);insert into Courses (CourseName, CourseCode, credits, DoctorId) values ('Database Systems', 'CS310', 3, 1);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Courses");

        }
    }
}
