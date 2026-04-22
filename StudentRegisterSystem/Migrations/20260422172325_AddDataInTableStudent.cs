using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentRegisterSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInTableStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Students (FirstName, LastName, StudentCode, DateOfBirth, Email, PhoneNumber, EnrollmentDate) values ('Ahmed', 'Sakr', 'STU-10', '1/6/2004', 'AhmedSakr@ebay.co.uk', '(+20) 01002525', '10/25/2025');insert into Students (FirstName, LastName, StudentCode, DateOfBirth, Email, PhoneNumber, EnrollmentDate) values ('Youssef', 'Issa', 'STU-20', '11/19/2002', 'YoussefIssa@washingtonpost.com', '(+20) 01547555', '2/5/2024');insert into Students (FirstName, LastName, StudentCode, DateOfBirth, Email, PhoneNumber, EnrollmentDate) values ('Ali', 'Kaled', 'STU-30', '4/19/2009', 'AliKhaled@usatoday.com', '(+20) 0125252', '2/5/2022');insert into Students (FirstName, LastName, StudentCode, DateOfBirth, Email, PhoneNumber, EnrollmentDate) values ('Mohamed', 'Khalaf', 'STU-40', '1/3/2009', 'MohamedKhalaf@altervista.org', '(+20) 0147852', '8/6/2023');insert into Students (FirstName, LastName, StudentCode, DateOfBirth, Email, PhoneNumber, EnrollmentDate) values ('Mahmoud', 'Hisham', 'STU-50', '11/2/2010', 'MahmoudHisham@buzzfeed.com', '(+20) 0135855', '8/31/2020');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Students");

        }
    }
}
