using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreBook.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Editor",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Publish",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Series",
                table: "Book");

            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EditorID",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GenreID",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PublishID",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeriesID",
                table: "Book",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorID",
                table: "Book",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Book_EditorID",
                table: "Book",
                column: "EditorID");

            migrationBuilder.CreateIndex(
                name: "IX_Book_GenreID",
                table: "Book",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublishID",
                table: "Book",
                column: "PublishID");

            migrationBuilder.CreateIndex(
                name: "IX_Book_SeriesID",
                table: "Book",
                column: "SeriesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_AuthorID",
                table: "Book",
                column: "AuthorID",
                principalTable: "Author",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Editor_EditorID",
                table: "Book",
                column: "EditorID",
                principalTable: "Editor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Genre_GenreID",
                table: "Book",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Publish_PublishID",
                table: "Book",
                column: "PublishID",
                principalTable: "Publish",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Series_SeriesID",
                table: "Book",
                column: "SeriesID",
                principalTable: "Series",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_AuthorID",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Editor_EditorID",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Genre_GenreID",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publish_PublishID",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Series_SeriesID",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_AuthorID",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_EditorID",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_GenreID",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_PublishID",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_SeriesID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "EditorID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "PublishID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "SeriesID",
                table: "Book");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Editor",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Publish",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Series",
                table: "Book",
                nullable: true);
        }
    }
}
