using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentExercises_EF.Data.Migrations
{
    public partial class AddedInstructorsExercises : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "Language", "Name" },
                values: new object[,]
                {
                    { 1, "C#", "Restauraunt Tracker" },
                    { 2, "C#", "Student Exercises" },
                    { 3, "C#", "Server Side Capstone" }
                });

            migrationBuilder.InsertData(
                table: "Instructor",
                columns: new[] { "Id", "CohortId", "FirstName", "LastName", "SlackHandle", "Specialty" },
                values: new object[,]
                {
                    { 1, 3, "Jordan", "Castelloe", "@jordan", "Rat exterminator" },
                    { 2, 3, "Tommy", "Spurlock", "@tommy", "Inspiring Speeches" },
                    { 3, 2, "Jordan", "Castelloe", "@jordan", "Muppets" },
                    { 4, 2, "Tommy", "Spurlock", "@tommy", "Dance Lessons" },
                    { 5, 1, "Jordan", "Castelloe", "@jordan", "Hoagie" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
