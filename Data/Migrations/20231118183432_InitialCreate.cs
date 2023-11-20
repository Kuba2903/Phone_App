using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookContact",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Number = table.Column<string>(type: "TEXT", maxLength: 9, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookContact", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "BookContact",
                columns: new[] { "ID", "Address", "Email", "Name", "Number" },
                values: new object[] { 1, "Some address", "someone@gmail.com", "someone", "234528690" });

            migrationBuilder.InsertData(
                table: "BookContact",
                columns: new[] { "ID", "Address", "Email", "Name", "Number" },
                values: new object[] { 2, null, null, "someone2", "949291345" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookContact");
        }
    }
}
