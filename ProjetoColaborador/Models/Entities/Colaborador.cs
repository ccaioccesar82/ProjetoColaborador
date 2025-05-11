using System.ComponentModel.DataAnnotations;
using ProjetoColaborador.Models.Entities.Enums;

namespace ProjetoColaborador.Models.Entities
{
    public class Colaborador
    {
        public long Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Telefone { get; set; } = string.Empty;

        public CargosId CargoId { get; set; }
        public Cargos? Cargo { get; set; }

    }
}
