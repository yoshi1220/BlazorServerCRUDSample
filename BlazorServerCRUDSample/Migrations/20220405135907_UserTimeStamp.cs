using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerCRUDSample.Migrations
{
    public partial class UserTimeStamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "TimeStamp",
                table: "Users",
                type: "rowversion",
                rowVersion: true,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "Users");
        }
    }
}
