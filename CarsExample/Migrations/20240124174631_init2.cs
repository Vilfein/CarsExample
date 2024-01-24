using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsExample.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Driver_DriverId",
                table: "Car");

            migrationBuilder.AlterColumn<int>(
                name: "DriverId",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Driver_DriverId",
                table: "Car",
                column: "DriverId",
                principalTable: "Driver",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Driver_DriverId",
                table: "Car");

            migrationBuilder.AlterColumn<int>(
                name: "DriverId",
                table: "Car",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Driver_DriverId",
                table: "Car",
                column: "DriverId",
                principalTable: "Driver",
                principalColumn: "Id");
        }
    }
}
