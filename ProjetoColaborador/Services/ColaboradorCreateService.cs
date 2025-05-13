using ProjetoColaborador.Data.Repositories.Interfaces;
using ProjetoColaborador.Models.Entities;
using ProjetoColaborador.Services.ServicesInterfaces;
using ProjetoColaborador.Services.Validator;
namespace ProjetoColaborador.Services
{
    public class ColaboradorCreateService: IColaboradorCreateService
    {

        private readonly IWriteColaboradorRepository _repository;


        public ColaboradorCreateService(IWriteColaboradorRepository repository)
        {
            _repository = repository;
        }

        public async Task Execute(ColaboradorDTO request)
        {
            RequestValidator.ValidateFields(request);

            Colaborador domainColaborador = new Colaborador()
            {
                Name = request.Name,
                Email = request.Email,
                Telefone = request.Telefone,
                CargoID = request.CargoID,
            }; 


            await _repository.CreateColaborador(domainColaborador);

        }
    }
}
