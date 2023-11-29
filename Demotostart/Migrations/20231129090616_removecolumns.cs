using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demotostart.Migrations
{
    /// <inheritdoc />
    public partial class removecolumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CDistrict",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CState",
                table: "Countries");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CDistrict",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CState",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
