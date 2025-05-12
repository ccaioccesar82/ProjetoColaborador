using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoColaborador.Models.Entities
{
    public class Colaborador
    {
        public long Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Telefone { get; set; } = string.Empty;

        public string CargoName { get; set; } = string.Empty;

        public long CargoID { get; set; }
        public virtual Cargos Cargo { get; set; }

    }
}
