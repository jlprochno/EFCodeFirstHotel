﻿// <auto-generated />
using System;
using EFCodeFirstHotel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCodeFirstHotel.Migrations
{
    [DbContext(typeof(EFCodeFirstHotelContext))]
    [Migration("20240126181737_CreateDatabase")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCodeFirstHotel.CheckIn", b =>
                {
                    b.Property<int>("CodCheckIn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodCheckIn"));

                    b.Property<int?>("CodCliente1")
                        .HasColumnType("int");

                    b.Property<int>("PeriodoPermanecia")
                        .HasColumnType("int");

                    b.Property<string>("StatusCheckIn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodCheckIn");

                    b.HasIndex("CodCliente1");

                    b.ToTable("CheckIns");
                });

            modelBuilder.Entity("EFCodeFirstHotel.CheckOut", b =>
                {
                    b.Property<int>("CodNotaFiscal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodNotaFiscal"));

                    b.Property<int?>("CodCliente1")
                        .HasColumnType("int");

                    b.Property<string>("PagamantoNotaFiscal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TaxaColchao")
                        .HasColumnType("float");

                    b.Property<double>("ValorDiariaCasal")
                        .HasColumnType("float");

                    b.Property<double>("ValorDiariaFamília")
                        .HasColumnType("float");

                    b.Property<double>("ValorDiariaPresidencial")
                        .HasColumnType("float");

                    b.Property<double>("ValorDiariaSolteiro")
                        .HasColumnType("float");

                    b.HasKey("CodNotaFiscal");

                    b.HasIndex("CodCliente1");

                    b.ToTable("CheckOuts");
                });

            modelBuilder.Entity("EFCodeFirstHotel.Cliente", b =>
                {
                    b.Property<int>("CodCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodCliente"));

                    b.Property<string>("EmailCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NacionalidadeCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("EFCodeFirstHotel.Consumo", b =>
                {
                    b.Property<int>("CodConsumo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodConsumo"));

                    b.Property<int?>("CodCheckIn")
                        .HasColumnType("int");

                    b.Property<string>("DescricaoConsumo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DtConsumo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ValorConsumo")
                        .HasColumnType("float");

                    b.HasKey("CodConsumo");

                    b.HasIndex("CodCheckIn");

                    b.ToTable("Consumos");
                });

            modelBuilder.Entity("EFCodeFirstHotel.ContatosCliente", b =>
                {
                    b.Property<int>("CodContato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodContato"));

                    b.Property<int?>("CodCliente1")
                        .HasColumnType("int");

                    b.Property<string>("EnderecoContato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefoneContato")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodContato");

                    b.HasIndex("CodCliente1");

                    b.ToTable("ContatosClientes");
                });

            modelBuilder.Entity("EFCodeFirstHotel.Funcionario", b =>
                {
                    b.Property<int>("CodFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodFuncionario"));

                    b.Property<string>("CargoFuncionario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFuncionario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodFuncionario");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("EFCodeFirstHotel.Hotel", b =>
                {
                    b.Property<int>("CodHotel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodHotel"));

                    b.Property<string>("EnderecoHotel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeHotel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantidadeEstrelasHotel")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeQuartos")
                        .HasColumnType("int");

                    b.Property<string>("TipoQuarto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodHotel");

                    b.ToTable("Hoteis");
                });

            modelBuilder.Entity("EFCodeFirstHotel.Lavanderia", b =>
                {
                    b.Property<int>("CodConsumoLavanderia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodConsumoLavanderia"));

                    b.Property<int?>("CodConsumo1")
                        .HasColumnType("int");

                    b.Property<string>("ServicoLavanderia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ValorConsumoLavanderia")
                        .HasColumnType("float");

                    b.Property<double>("ValorServicoLavanderia")
                        .HasColumnType("float");

                    b.HasKey("CodConsumoLavanderia");

                    b.HasIndex("CodConsumo1");

                    b.ToTable("Lavanderias");
                });

            modelBuilder.Entity("EFCodeFirstHotel.Quarto", b =>
                {
                    b.Property<int>("NumeroQuarto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NumeroQuarto"));

                    b.Property<string>("Adaptado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CodHotel1")
                        .HasColumnType("int");

                    b.Property<string>("TipoQuarto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NumeroQuarto");

                    b.HasIndex("CodHotel1");

                    b.ToTable("Quartos");
                });

            modelBuilder.Entity("EFCodeFirstHotel.Reserva", b =>
                {
                    b.Property<int>("CodReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodReserva"));

                    b.Property<int?>("CodCliente1")
                        .HasColumnType("int");

                    b.Property<int?>("CodFuncionario1")
                        .HasColumnType("int");

                    b.Property<int?>("CodHotel1")
                        .HasColumnType("int");

                    b.Property<string>("DtFimReserva")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DtInicioReserva")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DtReserva")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumeroQuarto1")
                        .HasColumnType("int");

                    b.Property<string>("StatusReserva")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoReserva")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("colchaoOpcional")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodReserva");

                    b.HasIndex("CodCliente1");

                    b.HasIndex("CodFuncionario1");

                    b.HasIndex("CodHotel1");

                    b.HasIndex("NumeroQuarto1");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("EFCodeFirstHotel.Restaurante", b =>
                {
                    b.Property<int>("CodConsumoRestarante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodConsumoRestarante"));

                    b.Property<int?>("CodConsumo1")
                        .HasColumnType("int");

                    b.Property<double>("ConsumoEntregaQuarto")
                        .HasColumnType("float");

                    b.Property<double>("ConsumoFrigobar")
                        .HasColumnType("float");

                    b.Property<double>("ConsumoRestaurante")
                        .HasColumnType("float");

                    b.Property<double>("TaxaEntregaQuarto")
                        .HasColumnType("float");

                    b.HasKey("CodConsumoRestarante");

                    b.HasIndex("CodConsumo1");

                    b.ToTable("Restaurantes");
                });

            modelBuilder.Entity("EFCodeFirstHotel.CheckIn", b =>
                {
                    b.HasOne("EFCodeFirstHotel.Cliente", "CodCliente")
                        .WithMany("CheckIns")
                        .HasForeignKey("CodCliente1");

                    b.Navigation("CodCliente");
                });

            modelBuilder.Entity("EFCodeFirstHotel.CheckOut", b =>
                {
                    b.HasOne("EFCodeFirstHotel.Cliente", "CodCliente")
                        .WithMany("CheckOuts")
                        .HasForeignKey("CodCliente1");

                    b.Navigation("CodCliente");
                });

            modelBuilder.Entity("EFCodeFirstHotel.Consumo", b =>
                {
                    b.HasOne("EFCodeFirstHotel.CheckIn", "CodCheckin")
                        .WithMany("Consumos")
                        .HasForeignKey("CodCheckIn");

                    b.Navigation("CodCheckin");
                });

            modelBuilder.Entity("EFCodeFirstHotel.ContatosCliente", b =>
                {
                    b.HasOne("EFCodeFirstHotel.Cliente", "CodCliente")
                        .WithMany("ContatosClientes")
                        .HasForeignKey("CodCliente1");

                    b.Navigation("CodCliente");
                });

            modelBuilder.Entity("EFCodeFirstHotel.Lavanderia", b =>
                {
                    b.HasOne("EFCodeFirstHotel.Consumo", "CodConsumo")
                        .WithMany("Lavanderias")
                        .HasForeignKey("CodConsumo1");

                    b.Navigation("CodConsumo");
                });

            modelBuilder.Entity("EFCodeFirstHotel.Quarto", b =>
                {
                    b.HasOne("EFCodeFirstHotel.Hotel", "CodHotel")
                        .WithMany("Quartos")
                        .HasForeignKey("CodHotel1");

                    b.Navigation("CodHotel");
                });

            modelBuilder.Entity("EFCodeFirstHotel.Reserva", b =>
                {
                    b.HasOne("EFCodeFirstHotel.Cliente", "CodCliente")
                        .WithMany("Reservas")
                        .HasForeignKey("CodCliente1");

                    b.HasOne("EFCodeFirstHotel.Funcionario", "CodFuncionario")
                        .WithMany("Reservas")
                        .HasForeignKey("CodFuncionario1");

                    b.HasOne("EFCodeFirstHotel.Hotel", "CodHotel")
                        .WithMany("Reservas")
                        .HasForeignKey("CodHotel1");

                    b.HasOne("EFCodeFirstHotel.Quarto", "NumeroQuarto")
                        .WithMany("Reservas")
                        .HasForeignKey("NumeroQuarto1");

                    b.Navigation("CodCliente");

                    b.Navigation("CodFuncionario");

                    b.Navigation("CodHotel");

                    b.Navigation("NumeroQuarto");
                });

            modelBuilder.Entity("EFCodeFirstHotel.Restaurante", b =>
                {
                    b.HasOne("EFCodeFirstHotel.Consumo", "CodConsumo")
                        .WithMany("Restaurantes")
                        .HasForeignKey("CodConsumo1");

                    b.Navigation("CodConsumo");
                });

            modelBuilder.Entity("EFCodeFirstHotel.CheckIn", b =>
                {
                    b.Navigation("Consumos");
                });

            modelBuilder.Entity("EFCodeFirstHotel.Cliente", b =>
                {
                    b.Navigation("CheckIns");

                    b.Navigation("CheckOuts");

                    b.Navigation("ContatosClientes");

                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("EFCodeFirstHotel.Consumo", b =>
                {
                    b.Navigation("Lavanderias");

                    b.Navigation("Restaurantes");
                });

            modelBuilder.Entity("EFCodeFirstHotel.Funcionario", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("EFCodeFirstHotel.Hotel", b =>
                {
                    b.Navigation("Quartos");

                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("EFCodeFirstHotel.Quarto", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
