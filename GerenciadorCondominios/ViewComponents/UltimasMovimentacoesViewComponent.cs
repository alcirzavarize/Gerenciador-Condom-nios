﻿using GerenciadorCondominios.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorCondominios.ViewComponents
{
    public class UltimasMovimentacoesViewComponent : ViewComponent
    {
        private readonly IHistoricoRecursosRepositorio _historicoRecursosRepositorio;

        public UltimasMovimentacoesViewComponent(IHistoricoRecursosRepositorio historicoRecursosRepositorio)
        {
            _historicoRecursosRepositorio = historicoRecursosRepositorio;

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _historicoRecursosRepositorio.PagarUltimasMovimentacoes());
        }

    }
}
