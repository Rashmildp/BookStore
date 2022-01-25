using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticeAPI.Migrations
{
    public partial class AddAuthorEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Country", "FirstName", "LastName" },
                values: new object[] { 1, "England", "J. K.", "Rowling" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Country", "FirstName", "LastName" },
                values: new object[] { 2, "Ireland", "Jonathan", "Swift" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Country", "FirstName", "LastName" },
                values: new object[] { 3, "England", "Daniel", "Defoe" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorId",
                table: "Books");
        }
    }
}
