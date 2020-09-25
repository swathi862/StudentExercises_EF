using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentExercises_EF.Data.Migrations
{
    public partial class AddedStudentsCohorts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cohort",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Day Cohort 1" });

            migrationBuilder.InsertData(
                table: "Cohort",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Day Cohort 2" });

            migrationBuilder.InsertData(
                table: "Cohort",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Day Cohort 3" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "CohortId", "FirstName", "LastName", "SlackHandle" },
                values: new object[,]
                {
                    { 2, 1, "Susan", "MacAfee", "@susan" },
                    { 1, 2, "Jakob", "Wildman", "Jakob" },
                    { 3, 3, "Barry", "Griffith", "@barry" },
                    { 4, 3, "Pat", "Shaver", "@pat" },
                    { 5, 3, "Mandy", "Campbell", "@mandy" },
                    { 6, 3, "Sarah", "Brooks", "@sarah" },
                    { 7, 3, "Swathi", "Mukkamala", "@swathi" },
                    { 8, 3, "Ashon", "Woodbury", "@ashon" },
                    { 9, 3, "Dylan", "Bishop", "@dylan" },
                    { 10, 3, "Austin", "Preece", "@austin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cohort",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
