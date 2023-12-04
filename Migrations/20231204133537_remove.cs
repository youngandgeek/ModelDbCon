using Microsoft.EntityFrameworkCore.Migrations;

namespace ModelDbCon.Migrations
{
    public partial class remove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dept_Name",
                table: "Course");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "dept_Name",
                table: "Course",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
