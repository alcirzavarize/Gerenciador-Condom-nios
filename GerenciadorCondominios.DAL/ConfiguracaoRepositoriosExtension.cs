﻿using GerenciadorCondominios.DAL.Interfaces;
using GerenciadorCondominios.DAL.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL
{
    public static class ConfiguracaoRepositoriosExtension
    {
        public static void ConfigurarRepositorios(this IServiceCollection services)
        {
            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddTransient<IFuncaoRepositorio, FuncaoRepositorio>();
            services.AddTransient<IVeiculoRepositorio, VeiculoRepositorio>();
            services.AddTransient<IEventoRepositorio, EventoRepositorio>();
            services.AddTransient<IServicoRepositorio, ServicoRepositorio>(); 
            services.AddTransient<IServicoPredioRepositorio, ServicoPredioRepositorio>();
            services.AddTransient<IHistoricoRecursosRepositorio, HistoricoRecursosRepositorio>();
            services.AddTransient<IApartamentoRepositorio, ApartamentoRepositorio>();
            services.AddTransient<IAluguelRepositorio, AluguelRepositorio>();
            services.AddTransient<IMesRepositorio, MesRepositorio>();            
            services.AddTransient<IPagamentoRepositorio, PagamentoRepositorio>();


        }
    }
}
