using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class modifyUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdentificationCard",
                table: "Users",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdentificationCard",
                table: "Users",
                column: "IdentificationCard");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_People_IdentificationCard",
                table: "Users",
                column: "IdentificationCard",
                principalTable: "People",
                principalColumn: "IdentificationCard");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_People_IdentificationCard",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_IdentificationCard",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "IdentificationCard",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);
        }
    }
}
