using ProjetoColaborador.Models.Entities.Enums;

namespace ProjetoColaborador.Models.Entities
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;

        public Cargos CargoId { get; set; }

    }
}
