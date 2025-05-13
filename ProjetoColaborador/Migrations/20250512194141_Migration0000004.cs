using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoColaborador.Migrations
{
    /// <inheritdoc />
    public partial class Migration0000004 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CargoName",
                table: "Colaboradores",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CargoName",
                table: "Colaboradores");
        }
    }
}
