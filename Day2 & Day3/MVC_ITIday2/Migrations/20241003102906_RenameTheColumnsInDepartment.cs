using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_ITIday2.Migrations
{
    /// <inheritdoc />
    public partial class RenameTheColumnsInDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "DepartmentSet",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "DepartmentSet",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "DepartmentSet",
                newName: "ManegerName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "DepartmentSet",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DepartmentSet",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ManegerName",
                table: "DepartmentSet",
                newName: "description");
        }
    }
}
