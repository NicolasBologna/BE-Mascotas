using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_CRUDMascotas.Migrations
{
    public partial class makeOwnerOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Duenios_DuenioId",
                table: "Mascotas");

            migrationBuilder.AlterColumn<int>(
                name: "DuenioId",
                table: "Mascotas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Duenios_DuenioId",
                table: "Mascotas",
                column: "DuenioId",
                principalTable: "Duenios",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Duenios_DuenioId",
                table: "Mascotas");

            migrationBuilder.AlterColumn<int>(
                name: "DuenioId",
                table: "Mascotas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Duenios_DuenioId",
                table: "Mascotas",
                column: "DuenioId",
                principalTable: "Duenios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
