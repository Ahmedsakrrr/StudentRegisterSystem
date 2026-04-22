using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentRegisterSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInTableDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Doctors (FirstName, LastName, specialty, Email, PhoneNumber, HireDate) values ('Dr/Khaled', 'Fathy', 'Computer Science', 'KhaledFathy@gmail.com', '(+20) 01092928', '7/12/2011');insert into Doctors (FirstName, LastName, specialty, Email, PhoneNumber, HireDate) values ('Dr/Alaa', 'Zaki', 'Network Engineering', 'AlaaZaki@gmail.com', '(+20) 01165855', '10/15/2012');insert into Doctors (FirstName, LastName, specialty, Email, PhoneNumber, HireDate) values ('Dr/Elmohamady', 'Elmohamady', 'IE', 'Almohamade@gmail.com', '(+20) 012555555', '8/19/2013');insert into Doctors (FirstName, LastName, specialty, Email, PhoneNumber, HireDate) values ('Dr/Heba', 'Rashed', 'AI Engineering', 'HebaRashed@gmail.com', '(+20) 01555542', '3/18/2014');insert into Doctors (FirstName, LastName, specialty, Email, PhoneNumber, HireDate) values ('Dr/Mohamed', 'Helal', 'Mathematics', 'MohamedHelal@gmail.com', '(+20) 0152525', '4/24/2015');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Doctors");

        }
    }
}
