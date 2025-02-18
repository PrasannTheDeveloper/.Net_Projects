using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagmentSystemIdentity.Data.Migrations
{
    /// <inheritdoc />
    public partial class newData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName", "Bio", "BirthDate", "DeadDate" },
                values: new object[,]
                {
                    { 1, "J.K. Rowling", "Author of Harry Potter series", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "George Orwell", "Author of 1984 & Animal Farm", new DateTime(1903, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Mark Twain", "Author of Tom Sawyer", new DateTime(1835, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1910, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "J.R.R. Tolkien", "Lord of the Rings", new DateTime(1892, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Stephen King", "Horror fiction writer", new DateTime(1947, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "Ernest Hemingway", "Author of The Old Man and The Sea", new DateTime(1899, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "F. Scott Fitzgerald", "The Great Gatsby", new DateTime(1896, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1940, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Agatha Christie", "Queen of Crime", new DateTime(1890, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Leo Tolstoy", "War and Peace", new DateTime(1828, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1910, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Jane Austen", "Pride and Prejudice", new DateTime(1775, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1817, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "CollegeId", "CollegeAddress", "CollegeEmail", "CollegeName" },
                values: new object[,]
                {
                    { 1, "Cambridge, MA", "info@harvard.edu", "Harvard University" },
                    { 2, "Cambridge, MA", "contact@mit.edu", "MIT" },
                    { 3, "Stanford, CA", "info@stanford.edu", "Stanford University" },
                    { 4, "Oxford, UK", "admin@ox.ac.uk", "Oxford University" },
                    { 5, "Cambridge, UK", "info@cam.ac.uk", "Cambridge University" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "BookName", "Description" },
                values: new object[,]
                {
                    { 1, 1, "Harry Potter", "Magic story" },
                    { 2, 2, "1984", "Dystopian fiction" },
                    { 3, 2, "Animal Farm", "Political satire" },
                    { 4, 4, "The Hobbit", "Fantasy novel" },
                    { 5, 5, "The Shining", "Horror story" },
                    { 6, 8, "Murder on the Orient Express", "Detective novel" },
                    { 7, 10, "Pride and Prejudice", "Romantic novel" },
                    { 8, 7, "The Great Gatsby", "American classic" },
                    { 9, 9, "War and Peace", "Historical fiction" },
                    { 10, 6, "The Old Man and The Sea", "Adventure novel" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "CollegeId", "StudentAddress", "StudentAge", "StudentEmail", "StudentName", "StudentPhone" },
                values: new object[,]
                {
                    { 1, 1, "NYC", 21, "alice@email.com", "Alice Johnson", "1234567890" },
                    { 2, 2, "Boston", 22, "bob@email.com", "Bob Smith", "9876543210" }
                });

            migrationBuilder.InsertData(
                table: "StudentBooks",
                columns: new[] { "BookId", "StudentId", "BorrowedDate", "ReturnDate" },
                values: new object[] { 1, 1, new DateTime(2025, 2, 18, 18, 58, 13, 403, DateTimeKind.Local).AddTicks(741), new DateTime(2025, 3, 4, 18, 58, 13, 403, DateTimeKind.Local).AddTicks(754) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StudentBooks",
                keyColumns: new[] { "BookId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 1);
        }
    }
}
