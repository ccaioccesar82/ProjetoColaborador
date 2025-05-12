using ProjetoColaborador.Data.Repositories.Interfaces;
using ProjetoColaborador.Models.Entities;
using ProjetoColaborador.Services.ServicesInterfaces;
using ProjetoColaborador.Services.Validator;

namespace ProjetoColaborador.Services
{
    public class EditColaboradorService: IEditColaboradorService
    {
        private readonly IReadColaboradorRepository _readColaboradorRepository;
        private readonly IWriteColaboradorRepository _writeColaboradorRepository;


        public EditColaboradorService(IReadColaboradorRepository readColaboradorRepository, IWriteColaboradorRepository writeColaboradorRepository)
        {
            _readColaboradorRepository = readColaboradorRepository;
            _writeColaboradorRepository = writeColaboradorRepository;

        }

        public async Task Execute(Colaborador colaboradorRequest)
        {
            RequestValidator.ValidateFields(colaboradorRequest);

            var colaboradorResult = await _readColaboradorRepository.FindColaboradorById(colaboradorRequest.Id);

            await _writeColaboradorRepository.UpdateColaborador(colaboradorResult, colaboradorRequest);

        }


    }
}
