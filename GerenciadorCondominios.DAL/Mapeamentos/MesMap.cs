﻿using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    public class MesMap : IEntityTypeConfiguration<Mes>
    {
        public void Configure(EntityTypeBuilder<Mes> builder)
        {
            builder.HasKey(m => m.MesId);
            builder.Property(m => m.MesId).ValueGeneratedNever();

            builder.Property(m => m.Nome).IsRequired().HasMaxLength(30);
            builder.HasIndex(m => m.Nome).IsUnique();

            builder.HasMany(m => m.Alugueis).WithOne(m => m.Mes);
            builder.HasMany(m => m.HistoricoRecursos).WithOne(m => m.Mes);

            builder.HasData(
                new Mes
                {
                    MesId = 1,
                    Nome = "Janeriro"

                },
                new Mes
                {
                    MesId = 2,
                    Nome = "Fevereiro"

                },
                new Mes
                {
                    MesId = 3,
                    Nome = "Março"

                },
                new Mes
                {
                    MesId = 4,
                    Nome = "Abirl"

                },
                new Mes
                {
                    MesId = 5,
                    Nome = "Maio"

                },
                new Mes
                {
                    MesId = 6,
                    Nome = "Junho"

                },
                new Mes
                {
                    MesId = 7,
                    Nome = "Julho"

                },
                new Mes
                {
                    MesId = 8,
                    Nome = "Agosto"

                },
                new Mes
                {
                    MesId = 9,
                    Nome = "Setembro"

                },
                new Mes
                {
                    MesId = 10,
                    Nome = "Outubro"

                },
                new Mes
                {
                    MesId = 11,
                    Nome = "Novembro"

                },
                new Mes
                {
                    MesId = 12,
                    Nome = "Dezembro"

                });

            builder.ToTable("Meses");

        }
    }
}
