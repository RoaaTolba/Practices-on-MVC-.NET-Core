using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssigmentMVCday2.Migrations
{
    /// <inheritdoc />
    public partial class alterForeignkeyCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_instructors_courses_CourseId",
                table: "instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_instructors_departments_DepartmentId",
                table: "instructors");

            migrationBuilder.DropIndex(
                name: "IX_instructors_CourseId",
                table: "instructors");

            migrationBuilder.DropIndex(
                name: "IX_instructors_DepartmentId",
                table: "instructors");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "instructors");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "instructors");

            migrationBuilder.CreateIndex(
                name: "IX_instructors_crs_id",
                table: "instructors",
                column: "crs_id");

            migrationBuilder.CreateIndex(
                name: "IX_instructors_dep_id",
                table: "instructors",
                column: "dep_id");

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_courses_crs_id",
                table: "instructors",
                column: "crs_id",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_departments_dep_id",
                table: "instructors",
                column: "dep_id",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_instructors_courses_crs_id",
                table: "instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_instructors_departments_dep_id",
                table: "instructors");

            migrationBuilder.DropIndex(
                name: "IX_instructors_crs_id",
                table: "instructors");

            migrationBuilder.DropIndex(
                name: "IX_instructors_dep_id",
                table: "instructors");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_instructors_CourseId",
                table: "instructors",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_instructors_DepartmentId",
                table: "instructors",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_courses_CourseId",
                table: "instructors",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_departments_DepartmentId",
                table: "instructors",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
