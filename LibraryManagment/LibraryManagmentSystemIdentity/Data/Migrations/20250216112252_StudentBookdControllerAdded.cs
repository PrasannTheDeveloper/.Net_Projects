using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagmentSystemIdentity.Data.Migrations
{
    /// <inheritdoc />
    public partial class StudentBookdControllerAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentBooksModel_Books_BookId",
                table: "StudentBooksModel");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentBooksModel_Students_StudentId",
                table: "StudentBooksModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentBooksModel",
                table: "StudentBooksModel");

            migrationBuilder.RenameTable(
                name: "StudentBooksModel",
                newName: "StudentBooks");

            migrationBuilder.RenameIndex(
                name: "IX_StudentBooksModel_BookId",
                table: "StudentBooks",
                newName: "IX_StudentBooks_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentBooks",
                table: "StudentBooks",
                columns: new[] { "StudentId", "BookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentBooks_Books_BookId",
                table: "StudentBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentBooks_Students_StudentId",
                table: "StudentBooks",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentBooks_Books_BookId",
                table: "StudentBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentBooks_Students_StudentId",
                table: "StudentBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentBooks",
                table: "StudentBooks");

            migrationBuilder.RenameTable(
                name: "StudentBooks",
                newName: "StudentBooksModel");

            migrationBuilder.RenameIndex(
                name: "IX_StudentBooks_BookId",
                table: "StudentBooksModel",
                newName: "IX_StudentBooksModel_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentBooksModel",
                table: "StudentBooksModel",
                columns: new[] { "StudentId", "BookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentBooksModel_Books_BookId",
                table: "StudentBooksModel",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentBooksModel_Students_StudentId",
                table: "StudentBooksModel",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
