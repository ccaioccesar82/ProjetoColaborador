using ProjetoColaborador.Data.Repositories.Interfaces;
using ProjetoColaborador.Models.Entities;

namespace ProjetoColaborador.Services
{
    public class ColaboradorCreateService
    {

        private readonly IWriteColaboradorRepository _repository;


        public ColaboradorCreateService(IWriteColaboradorRepository repository)
        {
            _repository = repository;
        }


    }
}
