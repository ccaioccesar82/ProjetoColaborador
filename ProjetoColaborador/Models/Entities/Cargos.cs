using ProjetoColaborador.Models.Entities.Enums;

namespace ProjetoColaborador.Models.Entities
{
    public class Cargos
    {
        public CargosId Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<Colaborador> Colaboradores { get; set; } = new List<Colaborador>();
    }
}
