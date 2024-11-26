using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group7FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class CartSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartID",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartID);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CartID",
                table: "Reservations",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserID",
                table: "Carts",
                column: "UserID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Carts_CartID",
                table: "Reservations",
                column: "CartID",
                principalTable: "Carts",
                principalColumn: "CartID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Carts_CartID",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_CartID",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "CartID",
                table: "Reservations");
        }
    }
}
