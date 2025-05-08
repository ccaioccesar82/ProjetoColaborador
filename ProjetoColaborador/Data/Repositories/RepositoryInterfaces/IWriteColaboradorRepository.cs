using ProjetoColaborador.Models.Entities;

namespace ProjetoColaborador.Data.Repositories.Interfaces
{
    public interface IWriteColaboradorRepository
    {
        public Task CreateColaborador(Colaborador colaborador);

        public Task UpdateColaborador(Guid colaboradorId, Colaborador colaborador);
    }
}
