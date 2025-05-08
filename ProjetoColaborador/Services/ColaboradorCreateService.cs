using System.Drawing;
using ProjetoColaborador.Data.Repositories.Interfaces;
using ProjetoColaborador.Models.Entities;
using ProjetoColaborador.Services.ServicesInterfaces;
namespace ProjetoColaborador.Services
{
    public class ColaboradorCreateService: IColaboradorCreateService
    {

        private readonly IWriteColaboradorRepository _repository;


        public ColaboradorCreateService(IWriteColaboradorRepository repository)
        {
            _repository = repository;
        }

        public async Task Execute(Colaborador request)
        {

            await _repository.CreateColaborador(request);
          

        }
    }
}
