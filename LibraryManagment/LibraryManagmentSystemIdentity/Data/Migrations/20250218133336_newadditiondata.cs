using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagmentSystemIdentity.Data.Migrations
{
    /// <inheritdoc />
    public partial class newadditiondata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
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

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1,
                column: "Bio",
                value: "British author, best known for the Harry Potter series.");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2,
                column: "Bio",
                value: "English novelist and essayist, known for 1984 and Animal Farm.");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3,
                columns: new[] { "AuthorName", "Bio", "BirthDate", "DeadDate" },
                values: new object[] { "Agatha Christie", "Queen of Mystery, famous for Hercule Poirot and Miss Marple novels.", new DateTime(1890, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "BookName", "Description" },
                values: new object[] { "Harry Potter and the Sorcerer’s Stone", "Fantasy novel about a young wizard" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "Description",
                value: "Dystopian novel about totalitarian surveillance");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "AuthorId", "BookName", "Description" },
                values: new object[] { 3, "Murder on the Orient Express", "Detective novel featuring Hercule Poirot" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "AuthorId", "BookName", "Description" },
                values: new object[] { 2, "Animal Farm", "Political satire with allegorical elements" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "AuthorId", "BookName", "Description" },
                values: new object[] { 3, "The ABC Murders", "Another thrilling mystery from Agatha Christie" });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 1,
                columns: new[] { "CollegeAddress", "CollegeEmail", "CollegeName" },
                values: new object[] { "Oxford, UK", "contact@ox.ac.uk", "Oxford University" });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 2,
                columns: new[] { "CollegeAddress", "CollegeEmail", "CollegeName" },
                values: new object[] { "Cambridge, MA, USA", "info@harvard.edu", "Harvard University" });

            migrationBuilder.UpdateData(
                table: "StudentBooks",
                keyColumns: new[] { "BookId", "StudentId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "BorrowedDate", "ReturnDate" },
                values: new object[] { new DateTime(2025, 2, 8, 19, 3, 35, 960, DateTimeKind.Local).AddTicks(6064), new DateTime(2025, 3, 10, 19, 3, 35, 960, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.InsertData(
                table: "StudentBooks",
                columns: new[] { "BookId", "StudentId", "BorrowedDate", "ReturnDate" },
                values: new object[] { 2, 2, new DateTime(2025, 2, 13, 19, 3, 35, 960, DateTimeKind.Local).AddTicks(6087), new DateTime(2025, 3, 5, 19, 3, 35, 960, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                columns: new[] { "StudentAddress", "StudentAge", "StudentEmail", "StudentPhone" },
                values: new object[] { "123 Maple St, London", 20, "alice.johnson@email.com", "123-456-7890" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                columns: new[] { "StudentAddress", "StudentEmail", "StudentPhone" },
                values: new object[] { "456 Oak St, Cambridge", "bob.smith@email.com", "987-654-3210" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "CollegeId", "StudentAddress", "StudentAge", "StudentEmail", "StudentName", "StudentPhone" },
                values: new object[] { 3, 1, "789 Pine St, Oxford", 21, "charlie.brown@email.com", "Charlie Brown", "555-555-5555" });

            migrationBuilder.InsertData(
                table: "StudentBooks",
                columns: new[] { "BookId", "StudentId", "BorrowedDate", "ReturnDate" },
                values: new object[] { 3, 3, new DateTime(2025, 2, 11, 19, 3, 35, 960, DateTimeKind.Local).AddTicks(6091), new DateTime(2025, 3, 4, 19, 3, 35, 960, DateTimeKind.Local).AddTicks(6092) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentBooks",
                keyColumns: new[] { "BookId", "StudentId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "StudentBooks",
                keyColumns: new[] { "BookId", "StudentId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1,
                column: "Bio",
                value: "Author of Harry Potter series");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2,
                column: "Bio",
                value: "Author of 1984 & Animal Farm");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3,
                columns: new[] { "AuthorName", "Bio", "BirthDate", "DeadDate" },
                values: new object[] { "Mark Twain", "Author of Tom Sawyer", new DateTime(1835, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1910, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName", "Bio", "BirthDate", "DeadDate" },
                values: new object[,]
                {
                    { 4, "J.R.R. Tolkien", "Lord of the Rings", new DateTime(1892, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Stephen King", "Horror fiction writer", new DateTime(1947, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "Ernest Hemingway", "Author of The Old Man and The Sea", new DateTime(1899, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1961, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "F. Scott Fitzgerald", "The Great Gatsby", new DateTime(1896, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1940, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Agatha Christie", "Queen of Crime", new DateTime(1890, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Leo Tolstoy", "War and Peace", new DateTime(1828, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1910, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Jane Austen", "Pride and Prejudice", new DateTime(1775, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1817, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "BookName", "Description" },
                values: new object[] { "Harry Potter", "Magic story" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "Description",
                value: "Dystopian fiction");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "AuthorId", "BookName", "Description" },
                values: new object[] { 2, "Animal Farm", "Political satire" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "AuthorId", "BookName", "Description" },
                values: new object[] { 4, "The Hobbit", "Fantasy novel" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "AuthorId", "BookName", "Description" },
                values: new object[] { 5, "The Shining", "Horror story" });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 1,
                columns: new[] { "CollegeAddress", "CollegeEmail", "CollegeName" },
                values: new object[] { "Cambridge, MA", "info@harvard.edu", "Harvard University" });

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 2,
                columns: new[] { "CollegeAddress", "CollegeEmail", "CollegeName" },
                values: new object[] { "Cambridge, MA", "contact@mit.edu", "MIT" });

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "CollegeId", "CollegeAddress", "CollegeEmail", "CollegeName" },
                values: new object[,]
                {
                    { 3, "Stanford, CA", "info@stanford.edu", "Stanford University" },
                    { 4, "Oxford, UK", "admin@ox.ac.uk", "Oxford University" },
                    { 5, "Cambridge, UK", "info@cam.ac.uk", "Cambridge University" }
                });

            migrationBuilder.UpdateData(
                table: "StudentBooks",
                keyColumns: new[] { "BookId", "StudentId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "BorrowedDate", "ReturnDate" },
                values: new object[] { new DateTime(2025, 2, 18, 18, 58, 13, 403, DateTimeKind.Local).AddTicks(741), new DateTime(2025, 3, 4, 18, 58, 13, 403, DateTimeKind.Local).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                columns: new[] { "StudentAddress", "StudentAge", "StudentEmail", "StudentPhone" },
                values: new object[] { "NYC", 21, "alice@email.com", "1234567890" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                columns: new[] { "StudentAddress", "StudentEmail", "StudentPhone" },
                values: new object[] { "Boston", "bob@email.com", "9876543210" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "BookName", "Description" },
                values: new object[,]
                {
                    { 6, 8, "Murder on the Orient Express", "Detective novel" },
                    { 7, 10, "Pride and Prejudice", "Romantic novel" },
                    { 8, 7, "The Great Gatsby", "American classic" },
                    { 9, 9, "War and Peace", "Historical fiction" },
                    { 10, 6, "The Old Man and The Sea", "Adventure novel" }
                });
        }
    }
}
