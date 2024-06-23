﻿// <auto-generated />
using System;
using Loja_de_Carros.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Loja_de_Carros.Migrations
{
    [DbContext(typeof(Loja_de_CarrosContext))]
    [Migration("20240621164336_NotaFormViewModel")]
    partial class NotaFormViewModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Loja_de_Carros.Models.Carro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AnoFabricação")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AnoModelo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Chassi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Preco")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carro");
                });

            modelBuilder.Entity("Loja_de_Carros.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cpf")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereço")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Loja_de_Carros.Models.Nota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarroId")
                        .HasColumnType("int");

                    b.Property<int>("CompradorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEmissao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Garantia")
                        .HasColumnType("datetime2");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<double>("ValorVenda")
                        .HasColumnType("float");

                    b.Property<int>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarroId");

                    b.HasIndex("CompradorId");

                    b.HasIndex("VendedorId");

                    b.ToTable("Nota");
                });

            modelBuilder.Entity("Loja_de_Carros.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("datetime2");

                    b.Property<int>("Matricula")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("Loja_de_Carros.Models.Nota", b =>
                {
                    b.HasOne("Loja_de_Carros.Models.Carro", "Carro")
                        .WithMany()
                        .HasForeignKey("CarroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Loja_de_Carros.Models.Cliente", "Comprador")
                        .WithMany()
                        .HasForeignKey("CompradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Loja_de_Carros.Models.Vendedor", "Vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carro");

                    b.Navigation("Comprador");

                    b.Navigation("Vendedor");
                });
#pragma warning restore 612, 618
        }
    }
}
