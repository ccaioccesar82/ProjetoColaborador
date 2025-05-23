﻿using ProjetoColaborador.Models.Entities;

namespace ProjetoColaborador.Services.ServicesInterfaces
{
    public interface IFindColaboradorService
    {
       public Task<IList<ColaboradorDTO>> FindAll();

        public Task<Colaborador> FindColaborador(long id);


        public Task<IList<Cargos>> FindCargos();
    }
}
