﻿using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.CPF).IsRequired().HasMaxLength(30);
            builder.HasIndex(u => u.CPF).IsUnique();
            builder.Property(u => u.Foto).IsRequired();
            builder.Property(u => u.PrimeiroAcesso).IsRequired();
            builder.Property(U => U.Status).IsRequired();

            builder.HasMany(u => u.PropietariosApartamentos).WithOne(u => u.Proprietario);
            builder.HasMany(u => u.MoradoresApartamentos).WithOne(u => u.Morador);
            builder.HasMany(u => u.Veiculos).WithOne(u => u.Usuario);
            builder.HasMany(u => u.Eventos).WithOne(u => u.Usuario);
            builder.HasMany(u => u.Pagamentos).WithOne(u => u.Usuario);
            builder.HasMany(u => u.Servicos).WithOne(u => u.Usuario);

            builder.ToTable("Usuarios");

        }
    }
}
