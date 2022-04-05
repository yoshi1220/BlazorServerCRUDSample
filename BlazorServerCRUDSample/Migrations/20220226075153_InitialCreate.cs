using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerCRUDSample.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "BirthDay", "MailAddress", "UserName" },
                values: new object[] { 1, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "yamada@mai.com", "山田太郎" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "BirthDay", "MailAddress", "UserName" },
                values: new object[] { 2, new DateTime(2009, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "takanashi@mail.com", "小鳥遊咲" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "BirthDay", "MailAddress", "UserName" },
                values: new object[] { 3, new DateTime(2004, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "anri@mail.com", "山本杏里" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
