using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoColaborador.Migrations
{
    /// <inheritdoc />
    public partial class Migration0000005 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CargoName",
                table: "Colaboradores");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CargoName",
                table: "Colaboradores",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
