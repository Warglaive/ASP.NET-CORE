using Microsoft.EntityFrameworkCore.Migrations;

namespace Panda.Data.Migrations
{
    public partial class nicknametest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nickName",
                table: "AspNetUsers",
                newName: "NickName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NickName",
                table: "AspNetUsers",
                newName: "nickName");
        }
    }
}
