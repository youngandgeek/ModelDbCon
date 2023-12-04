using Microsoft.EntityFrameworkCore.Migrations;

namespace ModelDbCon.Migrations
{
    public partial class course : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeptName",
                table: "Course");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeptName",
                table: "Course",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
