using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UStudentAPI.Migrations
{
    public partial class UStudentAPIModelsStudentContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    University = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "City", "Country", "FirstName", "LastName", "University" },
                values: new object[] { 1, "Yerevan", "Armenia", "Margarit", "Safaryan", "NPUA" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "City", "Country", "FirstName", "LastName", "University" },
                values: new object[] { 2, "Cambridge", "USA", "Will", "Smith", "MIT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
