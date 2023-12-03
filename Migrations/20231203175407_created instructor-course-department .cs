using Microsoft.EntityFrameworkCore.Migrations;

namespace ModelDbCon.Migrations
{
    public partial class createdinstructorcoursedepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Degree = table.Column<int>(type: "int", nullable: false),
                    MinDegree = table.Column<int>(type: "int", nullable: false),
                    dept_id = table.Column<int>(type: "int", nullable: false),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deptId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_Department_deptId",
                        column: x => x.deptId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dept_id = table.Column<int>(type: "int", nullable: false),
                    deptId = table.Column<int>(type: "int", nullable: true),
                    course_id = table.Column<int>(type: "int", nullable: false),
                    crsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructor_Course_crsId",
                        column: x => x.crsId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Instructor_Department_deptId",
                        column: x => x.deptId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_deptId",
                table: "Course",
                column: "deptId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_crsId",
                table: "Instructor",
                column: "crsId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_deptId",
                table: "Instructor",
                column: "deptId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropTable(
                name: "Course");
        }
    }
}
