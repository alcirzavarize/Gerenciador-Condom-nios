﻿using GerenciadorCondominios.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL.Interfaces
{
     public interface IHistoricoRecursosRepositorio : IRepositorioGenerico<HistoricoRecurso>
    {
        object PegarHistoricoGanhos(int ano);
        object PegarHistoricoDespesas(int ano);

        public Task<decimal> PegarSomaDespesas(int ano);
        public Task<decimal> PegarSomaGanhos(int ano);

        public Task<IEnumerable<HistoricoRecurso>> PagarUltimasMovimentacoes();
    }
}
