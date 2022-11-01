using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_CRUDMascotas.Migrations
{
    public partial class AddOwners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DuenioId",
                table: "Mascotas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Duenios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duenios", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_DuenioId",
                table: "Mascotas",
                column: "DuenioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Duenios_DuenioId",
                table: "Mascotas",
                column: "DuenioId",
                principalTable: "Duenios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Duenios_DuenioId",
                table: "Mascotas");

            migrationBuilder.DropTable(
                name: "Duenios");

            migrationBuilder.DropIndex(
                name: "IX_Mascotas_DuenioId",
                table: "Mascotas");

            migrationBuilder.DropColumn(
                name: "DuenioId",
                table: "Mascotas");
        }
    }
}
