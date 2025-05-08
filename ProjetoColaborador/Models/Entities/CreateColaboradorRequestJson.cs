using ProjetoColaborador.Models.Entities.Enums;

namespace ProjetoColaborador.Models.Entities
{
    public class CreateColaboradorRequestJson
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string CargoId { get; set; } = string.Empty;
    }
}
