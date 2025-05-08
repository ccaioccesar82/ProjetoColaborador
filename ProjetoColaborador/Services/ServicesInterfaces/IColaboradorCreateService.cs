using ProjetoColaborador.Models.Entities;

namespace ProjetoColaborador.Services.ServicesInterfaces
{
    public interface IColaboradorCreateService
    {
        public Task Execute(Colaborador request);
    }
}
