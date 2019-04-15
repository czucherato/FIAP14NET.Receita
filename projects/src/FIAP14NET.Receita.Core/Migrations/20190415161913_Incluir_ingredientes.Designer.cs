﻿// <auto-generated />
using System;
using FIAP14NET.Receita.Core.Persistencia.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FIAP14NET.Receita.Core.Migrations
{
    [DbContext(typeof(ReceitaContexto))]
    [Migration("20190415161913_Incluir_ingredientes")]
    partial class Incluir_ingredientes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FIAP14NET.Receita.Core.Dominio.Entidades.Receita", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AlteradoEm")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Ingredientes")
                        .HasColumnType("varchar(300)");

                    b.Property<string>("ModoDePreparo")
                        .HasColumnType("varchar(3000)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Receita");
                });
#pragma warning restore 612, 618
        }
    }
}
