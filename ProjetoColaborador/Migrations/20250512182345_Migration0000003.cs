using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjetoColaborador.Migrations
{
    /// <inheritdoc />
    public partial class Migration0000003 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradores_Cargos_CargoId",
                table: "Colaboradores");

            migrationBuilder.DeleteData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 0);

            migrationBuilder.DeleteData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "CargoId",
                table: "Colaboradores",
                newName: "CargoID");

            migrationBuilder.RenameIndex(
                name: "IX_Colaboradores_CargoId",
                table: "Colaboradores",
                newName: "IX_Colaboradores_CargoID");

            migrationBuilder.AlterColumn<long>(
                name: "CargoID",
                table: "Colaboradores",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Cargos",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradores_Cargos_CargoID",
                table: "Colaboradores",
                column: "CargoID",
                principalTable: "Cargos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradores_Cargos_CargoID",
                table: "Colaboradores");

            migrationBuilder.RenameColumn(
                name: "CargoID",
                table: "Colaboradores",
                newName: "CargoId");

            migrationBuilder.RenameIndex(
                name: "IX_Colaboradores_CargoID",
                table: "Colaboradores",
                newName: "IX_Colaboradores_CargoId");

            migrationBuilder.AlterColumn<int>(
                name: "CargoId",
                table: "Colaboradores",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Cargos",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.InsertData(
                table: "Cargos",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 0, "Programador" },
                    { 1, "Designer" },
                    { 2, "Comercial" },
                    { 3, "TechLeader" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradores_Cargos_CargoId",
                table: "Colaboradores",
                column: "CargoId",
                principalTable: "Cargos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
