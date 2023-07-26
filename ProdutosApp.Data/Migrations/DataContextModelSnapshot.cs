﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProdutosApp.Data.Contexts;

#nullable disable

namespace ProdutosApp.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProdutosApp.Data.Entities.Produto", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<DateTime?>("DataHoraCriacao")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("DATAHORACRIACAO");

                    b.Property<DateTime?>("DataHoraUltimaAlteracao")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("DATAHORAULTIMAALTERACAO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("NOME");

                    b.Property<decimal?>("Preco")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("PRECO");

                    b.Property<int?>("Quantidade")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("QUANTIDADE");

                    b.HasKey("Id");

                    b.ToTable("PRODUTO", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
