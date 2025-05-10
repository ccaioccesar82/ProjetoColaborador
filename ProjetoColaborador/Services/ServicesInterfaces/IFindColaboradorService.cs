using ProjetoColaborador.Models.Entities;

namespace ProjetoColaborador.Services.ServicesInterfaces
{
    public interface IFindColaboradorService
    {
        public Task<IList<Colaborador>> FindAll();

        public Task<Colaborador> FindColaboradorById(long id);
    }
}
