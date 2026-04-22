using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentRegisterSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInTableEnrollment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Enrollments (EnrollmentCode, StudentId, CourseId, EnrollmentDate) values ('ENR-1', 1, 1, '8/17/2026');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Enrollments");

        }
    }
}
