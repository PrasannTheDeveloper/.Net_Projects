using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagmentSystemIdentity.Data.Migrations
{
    /// <inheritdoc />
    public partial class books : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "BookName", "Description" },
                values: new object[,]
                {
                    { 11, 7, "The Catcher in the Rye", "Coming-of-age novel" },
                    { 12, 4, "The Lord of the Rings", "Epic high fantasy" },
                    { 13, 2, "Brave New World", "Dystopian science fiction" },
                    { 14, 2, "Fahrenheit 451", "Dystopian novel about censorship" },
                    { 15, 5, "Dracula", "Gothic horror" },
                    { 16, 5, "Frankenstein", "Gothic science fiction" },
                    { 17, 5, "The Picture of Dorian Gray", "Philosophical novel" },
                    { 18, 4, "The Chronicles of Narnia", "Fantasy novel series" },
                    { 19, 2, "The Hitchhiker's Guide to the Galaxy", "Comic science fiction" },
                    { 20, 1, "Alice's Adventures in Wonderland", "Fantasy novel" },
                    { 21, 10, "Wuthering Heights", "Gothic fiction" },
                    { 22, 5, "Gone with the Wind", "Historical fiction" },
                    { 23, 9, "A Tale of Two Cities", "Historical novel" },
                    { 24, 6, "The Sun Also Rises", "Modernist novel" },
                    { 25, 7, "To Kill a Mockingbird", "Southern Gothic fiction" },
                    { 26, 1, "The Kite Runner", "Historical fiction" },
                    { 27, 8, "The Book Thief", "Historical fiction" },
                    { 28, 2, "Slaughterhouse-Five", "Anti-war science fiction" },
                    { 29, 3, "The Great Expectations", "Victorian novel" },
                    { 30, 3, "Moby-Dick", "Epic sea adventure" },
                    { 31, 9, "Les Misérables", "Historical novel" },
                    { 32, 7, "Catch-22", "Satirical novel" },
                    { 33, 1, "The Fault in Our Stars", "Young adult novel" },
                    { 34, 8, "The Alchemist", "Philosophical fiction" },
                    { 35, 4, "The Secret Garden", "Children's novel" },
                    { 36, 2, "The Godfather", "Crime novel" },
                    { 37, 6, "The Road", "Post-apocalyptic novel" },
                    { 38, 5, "Shogun", "Historical novel" },
                    { 39, 2, "The Handmaid's Tale", "Dystopian novel" },
                    { 40, 1, "The Girl on the Train", "Psychological thriller" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 40);
        }
    }
}
