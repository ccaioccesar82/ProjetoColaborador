using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoColaborador.Migrations
{
    /// <inheritdoc />
    public partial class MigrationPopularTabelaCargos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Cargos",
                    columns: new[] { "Id", "Name" },
                values: new object[,]
                    {
                    { 1, "Programador" },
                    { 2, "Designer" },
                    { 3, "Comercial" },
                    { 4, "Tech leader" }
                 });


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
