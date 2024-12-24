using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchMaker.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatefirst1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ideas_Persons_GirlId",
                table: "Ideas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ideas_Persons_GuyId",
                table: "Ideas");

            migrationBuilder.AddForeignKey(
                name: "FK_Ideas_Persons_GirlId",
                table: "Ideas",
                column: "GirlId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ideas_Persons_GuyId",
                table: "Ideas",
                column: "GuyId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ideas_Persons_GirlId",
                table: "Ideas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ideas_Persons_GuyId",
                table: "Ideas");

            migrationBuilder.AddForeignKey(
                name: "FK_Ideas_Persons_GirlId",
                table: "Ideas",
                column: "GirlId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ideas_Persons_GuyId",
                table: "Ideas",
                column: "GuyId",
                principalTable: "Persons",
                principalColumn: "Id");
        }
    }
}
