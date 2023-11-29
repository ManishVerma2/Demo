using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demotostart.Migrations
{
    /// <inheritdoc />
    public partial class byh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descriptsion",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descriptsion",
                table: "Countries");
        }
    }
}
