using Microsoft.EntityFrameworkCore;
using ProjetoColaborador.Data.Repositories.Interfaces;
using ProjetoColaborador.Models.Entities;

namespace ProjetoColaborador.Data.Repositories
{
    public class WriteColaboradorRepository: IWriteColaboradorRepository
    {

        private readonly ColaboradorDbContext _dbContext;

        public WriteColaboradorRepository(ColaboradorDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task CreateColaborador(Colaborador colaborador)
        {
            var result = await _dbContext.Cargos.SingleAsync(cargo => cargo.Id == colaborador.Cargo.Id);

            colaborador.Cargo = result;
            colaborador.CargoName = colaborador.Cargo.Name;

            await _dbContext.Colaboradores.AddAsync(colaborador);

            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateColaborador(Colaborador colaboradorResult, Colaborador colaboradorRequest)
        {
            var cargoResult = await _dbContext.Cargos.SingleAsync(cargo => cargo.Id == colaboradorRequest.Cargo.Id);

            colaboradorResult.Name = colaboradorRequest.Name;
            colaboradorResult.Email = colaboradorRequest.Email;
            colaboradorResult.Telefone = colaboradorRequest.Telefone;

            colaboradorResult.Cargo = cargoResult;
            colaboradorResult.CargoName = colaboradorResult.Cargo.Name;

            _dbContext.Colaboradores.Update(colaboradorResult);

            await _dbContext.SaveChangesAsync();
        }

    }
}
