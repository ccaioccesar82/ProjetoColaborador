namespace ProjetoColaborador.Models.Entities
{
    public class ColaboradorDTO
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;       
        public long CargoID { get; set; }
        public string Cargo { get; set; } = string.Empty;


    }
}
