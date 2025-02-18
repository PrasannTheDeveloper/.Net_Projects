using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagmentSystemIdentity.Data.Migrations
{
    /// <inheritdoc />
    public partial class Students : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "CollegeId", "StudentAddress", "StudentAge", "StudentEmail", "StudentName", "StudentPhone" },
                values: new object[,]
                {
                    { 3, 3, "Los Angeles", 23, "charlie@email.com", "Charlie Brown", "1122334455" },
                    { 4, 4, "Chicago", 24, "david@email.com", "David Williams", "2233445566" },
                    { 5, 5, "Miami", 25, "emma@email.com", "Emma Davis", "3344556677" },
                    { 6, 1, "Seattle", 26, "fayla@email.com", "Fayla Clark", "4455667788" },
                    { 7, 2, "Dallas", 27, "george@email.com", "George Martin", "5566778899" },
                    { 8, 3, "San Francisco", 28, "hannah@email.com", "Hannah Lee", "6677889900" },
                    { 9, 4, "Houston", 29, "isaac@email.com", "Isaac Parker", "7788990011" },
                    { 10, 5, "Austin", 30, "jessica@email.com", "Jessica Allen", "8899001122" },
                    { 11, 1, "Denver", 21, "kevin@email.com", "Kevin Scott", "9900112233" },
                    { 12, 2, "Philadelphia", 22, "laura@email.com", "Laura Walker", "1011121314" },
                    { 13, 3, "Phoenix", 23, "matthew@email.com", "Matthew Hall", "1213141516" },
                    { 14, 4, "Boston", 24, "nancy@email.com", "Nancy Allen", "1415161718" },
                    { 15, 5, "Chicago", 25, "oliver@email.com", "Oliver Young", "1617181920" },
                    { 16, 1, "Seattle", 26, "paul@email.com", "Paul Harris", "1819202122" },
                    { 17, 2, "Los Angeles", 27, "quincy@email.com", "Quincy Lee", "2021222324" },
                    { 18, 3, "San Francisco", 28, "rachel@email.com", "Rachel Nelson", "2223242526" },
                    { 19, 4, "Houston", 29, "samuel@email.com", "Samuel Green", "2425262728" },
                    { 20, 5, "Dallas", 30, "tina@email.com", "Tina Carter", "2627282930" },
                    { 21, 1, "Phoenix", 21, "ursula@email.com", "Ursula King", "2829303132" },
                    { 22, 2, "Miami", 22, "victor@email.com", "Victor Adams", "3031323334" },
                    { 23, 3, "Austin", 23, "wendy@email.com", "Wendy Turner", "3233343536" },
                    { 24, 4, "Philadelphia", 24, "xander@email.com", "Xander Morris", "3435363738" },
                    { 25, 5, "San Francisco", 25, "yara@email.com", "Yara Phillips", "3637383940" },
                    { 26, 1, "New York", 26, "zane@email.com", "Zane Harris", "3839404142" },
                    { 27, 2, "Los Angeles", 27, "amy@email.com", "Amy Jenkins", "4041424344" },
                    { 28, 3, "Chicago", 28, "brandon@email.com", "Brandon Turner", "4243444546" },
                    { 29, 4, "Boston", 29, "christina@email.com", "Christina Miller", "4445464748" },
                    { 30, 5, "Seattle", 30, "dylan@email.com", "Dylan Evans", "4647484950" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 30);
        }
    }
}
