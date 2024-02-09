using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCodeFirstHotel.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabaserelacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quartos_Hoteis_CodHotel1",
                table: "Quartos");

            migrationBuilder.RenameColumn(
                name: "CodHotel1",
                table: "Quartos",
                newName: "HotelCodHotel");

            migrationBuilder.RenameIndex(
                name: "IX_Quartos_CodHotel1",
                table: "Quartos",
                newName: "IX_Quartos_HotelCodHotel");

            migrationBuilder.AddColumn<int>(
                name: "CodHotel",
                table: "Quartos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Quartos_Hoteis_HotelCodHotel",
                table: "Quartos",
                column: "HotelCodHotel",
                principalTable: "Hoteis",
                principalColumn: "CodHotel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quartos_Hoteis_HotelCodHotel",
                table: "Quartos");

            migrationBuilder.DropColumn(
                name: "CodHotel",
                table: "Quartos");

            migrationBuilder.RenameColumn(
                name: "HotelCodHotel",
                table: "Quartos",
                newName: "CodHotel1");

            migrationBuilder.RenameIndex(
                name: "IX_Quartos_HotelCodHotel",
                table: "Quartos",
                newName: "IX_Quartos_CodHotel1");

            migrationBuilder.AddForeignKey(
                name: "FK_Quartos_Hoteis_CodHotel1",
                table: "Quartos",
                column: "CodHotel1",
                principalTable: "Hoteis",
                principalColumn: "CodHotel");
        }
    }
}
