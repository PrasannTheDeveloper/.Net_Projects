using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagmentSystemIdentity.Data.Migrations
{
    /// <inheritdoc />
    public partial class joinedBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Students_StudentsModelStudentId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_StudentsModelStudentId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "StudentsModelStudentId",
                table: "Books");

            migrationBuilder.CreateTable(
                name: "BorrowedBooks",
                columns: table => new
                {
                    BooksBookId = table.Column<int>(type: "int", nullable: false),
                    StudentsStudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowedBooks", x => new { x.BooksBookId, x.StudentsStudentId });
                    table.ForeignKey(
                        name: "FK_BorrowedBooks_Books_BooksBookId",
                        column: x => x.BooksBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BorrowedBooks_Students_StudentsStudentId",
                        column: x => x.StudentsStudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_StudentsStudentId",
                table: "BorrowedBooks",
                column: "StudentsStudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowedBooks");

            migrationBuilder.AddColumn<int>(
                name: "StudentsModelStudentId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_StudentsModelStudentId",
                table: "Books",
                column: "StudentsModelStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Students_StudentsModelStudentId",
                table: "Books",
                column: "StudentsModelStudentId",
                principalTable: "Students",
                principalColumn: "StudentId");
        }
    }
}
