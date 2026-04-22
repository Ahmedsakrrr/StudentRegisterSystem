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
            migrationBuilder.Sql("insert into Courses (CourseName, CourseCode, credits) values ('Introduction to Computer Science', 'CS101', 3);insert into Courses (CourseName, CourseCode, credits) values ('Data Structures', 'CS201', 2);insert into Courses (CourseName, CourseCode, credits) values ('Algorithms', 'CS301', 1);insert into Courses (CourseName, CourseCode, credits) values ('Operating Systems', 'CS205', 3);insert into Courses (CourseName, CourseCode, credits) values ('Database Systems', 'CS310', 3);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Courses ;");
        }
    }
}
