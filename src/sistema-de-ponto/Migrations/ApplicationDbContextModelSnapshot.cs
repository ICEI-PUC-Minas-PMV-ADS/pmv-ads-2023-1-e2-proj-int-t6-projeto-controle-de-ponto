﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sistema_de_ponto.Models;

namespace sistema_de_ponto.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("sistema_de_ponto.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("sistema_de_ponto.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Pis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RegistraPontoId")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("RegistraPontoId");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("sistema_de_ponto.Models.Justificativa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnexarDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PontoId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("PontoId");

                    b.ToTable("Justificativa");
                });

            modelBuilder.Entity("sistema_de_ponto.Models.Ponto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("HoraEntrada")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraExtra")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraIntervaloFinal")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraIntervaloInicial")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraSaida")
                        .HasColumnType("time");

                    b.Property<string>("Turno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("Ponto");
                });

            modelBuilder.Entity("sistema_de_ponto.Models.RegistraPonto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("HoraEntrada1")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("HoraEntrada2")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("HoraSaida1")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("HoraSaida2")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("RegistraPontos");
                });

            modelBuilder.Entity("sistema_de_ponto.Models.Funcionario", b =>
                {
                    b.HasOne("sistema_de_ponto.Models.Empresa", "Empresa")
                        .WithMany("Funcionarios")
                        .HasForeignKey("EmpresaId");

                    b.HasOne("sistema_de_ponto.Models.RegistraPonto", null)
                        .WithMany("Funcionarios")
                        .HasForeignKey("RegistraPontoId");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("sistema_de_ponto.Models.Justificativa", b =>
                {
                    b.HasOne("sistema_de_ponto.Models.Funcionario", "Funcionario")
                        .WithMany("Justificativas")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sistema_de_ponto.Models.Ponto", "Ponto")
                        .WithMany("Justificativas")
                        .HasForeignKey("PontoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");

                    b.Navigation("Ponto");
                });

            modelBuilder.Entity("sistema_de_ponto.Models.Ponto", b =>
                {
                    b.HasOne("sistema_de_ponto.Models.Funcionario", "Funcionario")
                        .WithMany("Pontos")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("sistema_de_ponto.Models.RegistraPonto", b =>
                {
                    b.HasOne("sistema_de_ponto.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("sistema_de_ponto.Models.Empresa", b =>
                {
                    b.Navigation("Funcionarios");
                });

            modelBuilder.Entity("sistema_de_ponto.Models.Funcionario", b =>
                {
                    b.Navigation("Justificativas");

                    b.Navigation("Pontos");
                });

            modelBuilder.Entity("sistema_de_ponto.Models.Ponto", b =>
                {
                    b.Navigation("Justificativas");
                });

            modelBuilder.Entity("sistema_de_ponto.Models.RegistraPonto", b =>
                {
                    b.Navigation("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}
