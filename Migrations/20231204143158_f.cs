using Microsoft.EntityFrameworkCore.Migrations;

namespace ModelDbCon.Migrations
{
    public partial class f : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "dept_id",
                table: "Course",
                newName: "dept_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "dept_Id",
                table: "Course",
                newName: "dept_id");
        }
    }
}
