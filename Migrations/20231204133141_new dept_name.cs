using Microsoft.EntityFrameworkCore.Migrations;

namespace ModelDbCon.Migrations
{
    public partial class newdept_name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "dept_Name",
                table: "Course",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dept_Name",
                table: "Course");
        }
    }
}
