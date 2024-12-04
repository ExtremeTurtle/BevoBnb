using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group7FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class Dispute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisputeStatus",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisputeStatus",
                table: "Reviews");
        }
    }
}
