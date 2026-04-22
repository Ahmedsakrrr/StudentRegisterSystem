using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentRegisterSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInTableDoctorStudentAssignment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into DoctorStudentAssignments (DoctorStudentAssignmentCode, StudentId, DoctorId, AssignmentDate) values ('ASGN-1', 1, 1, '12/9/2026');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from DoctorStudentAssignments");
        }
    }
}
