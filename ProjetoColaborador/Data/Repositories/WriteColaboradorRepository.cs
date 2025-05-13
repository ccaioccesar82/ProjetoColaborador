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
            await _dbContext.Colaboradores.AddAsync(colaborador);

            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateColaborador(Colaborador colaborador)
        {


            _dbContext.Colaboradores.Update(colaborador);

            await _dbContext.SaveChangesAsync();
        }

    }
}
