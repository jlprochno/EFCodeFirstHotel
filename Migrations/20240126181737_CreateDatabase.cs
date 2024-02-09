using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCodeFirstHotel.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    CodCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NacionalidadeCliente = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.CodCliente);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    CodFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CargoFuncionario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeFuncionario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.CodFuncionario);
                });

            migrationBuilder.CreateTable(
                name: "Hoteis",
                columns: table => new
                {
                    CodHotel = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeHotel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantidadeQuartos = table.Column<int>(type: "int", nullable: false),
                    TipoQuarto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnderecoHotel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantidadeEstrelasHotel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoteis", x => x.CodHotel);
                });

            migrationBuilder.CreateTable(
                name: "CheckIns",
                columns: table => new
                {
                    CodCheckIn = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCliente1 = table.Column<int>(type: "int", nullable: true),
                    StatusCheckIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriodoPermanecia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckIns", x => x.CodCheckIn);
                    table.ForeignKey(
                        name: "FK_CheckIns_Clientes_CodCliente1",
                        column: x => x.CodCliente1,
                        principalTable: "Clientes",
                        principalColumn: "CodCliente");
                });

            migrationBuilder.CreateTable(
                name: "CheckOuts",
                columns: table => new
                {
                    CodNotaFiscal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCliente1 = table.Column<int>(type: "int", nullable: true),
                    PagamantoNotaFiscal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorDiariaSolteiro = table.Column<double>(type: "float", nullable: false),
                    ValorDiariaCasal = table.Column<double>(type: "float", nullable: false),
                    ValorDiariaFamília = table.Column<double>(type: "float", nullable: false),
                    ValorDiariaPresidencial = table.Column<double>(type: "float", nullable: false),
                    TaxaColchao = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckOuts", x => x.CodNotaFiscal);
                    table.ForeignKey(
                        name: "FK_CheckOuts_Clientes_CodCliente1",
                        column: x => x.CodCliente1,
                        principalTable: "Clientes",
                        principalColumn: "CodCliente");
                });

            migrationBuilder.CreateTable(
                name: "ContatosClientes",
                columns: table => new
                {
                    CodContato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCliente1 = table.Column<int>(type: "int", nullable: true),
                    TelefoneContato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnderecoContato = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContatosClientes", x => x.CodContato);
                    table.ForeignKey(
                        name: "FK_ContatosClientes_Clientes_CodCliente1",
                        column: x => x.CodCliente1,
                        principalTable: "Clientes",
                        principalColumn: "CodCliente");
                });

            migrationBuilder.CreateTable(
                name: "Quartos",
                columns: table => new
                {
                    NumeroQuarto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodHotel1 = table.Column<int>(type: "int", nullable: true),
                    Adaptado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoQuarto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quartos", x => x.NumeroQuarto);
                    table.ForeignKey(
                        name: "FK_Quartos_Hoteis_CodHotel1",
                        column: x => x.CodHotel1,
                        principalTable: "Hoteis",
                        principalColumn: "CodHotel");
                });

            migrationBuilder.CreateTable(
                name: "Consumos",
                columns: table => new
                {
                    CodConsumo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCheckIn = table.Column<int>(type: "int", nullable: true),
                    DescricaoConsumo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorConsumo = table.Column<double>(type: "float", nullable: false),
                    DtConsumo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumos", x => x.CodConsumo);
                    table.ForeignKey(
                        name: "FK_Consumos_CheckIns_CodCheckIn",
                        column: x => x.CodCheckIn,
                        principalTable: "CheckIns",
                        principalColumn: "CodCheckIn");
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    CodReserva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodHotel1 = table.Column<int>(type: "int", nullable: true),
                    NumeroQuarto1 = table.Column<int>(type: "int", nullable: true),
                    CodCliente1 = table.Column<int>(type: "int", nullable: true),
                    DtReserva = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DtInicioReserva = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DtFimReserva = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoReserva = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusReserva = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodFuncionario1 = table.Column<int>(type: "int", nullable: true),
                    colchaoOpcional = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.CodReserva);
                    table.ForeignKey(
                        name: "FK_Reservas_Clientes_CodCliente1",
                        column: x => x.CodCliente1,
                        principalTable: "Clientes",
                        principalColumn: "CodCliente");
                    table.ForeignKey(
                        name: "FK_Reservas_Funcionarios_CodFuncionario1",
                        column: x => x.CodFuncionario1,
                        principalTable: "Funcionarios",
                        principalColumn: "CodFuncionario");
                    table.ForeignKey(
                        name: "FK_Reservas_Hoteis_CodHotel1",
                        column: x => x.CodHotel1,
                        principalTable: "Hoteis",
                        principalColumn: "CodHotel");
                    table.ForeignKey(
                        name: "FK_Reservas_Quartos_NumeroQuarto1",
                        column: x => x.NumeroQuarto1,
                        principalTable: "Quartos",
                        principalColumn: "NumeroQuarto");
                });

            migrationBuilder.CreateTable(
                name: "Lavanderias",
                columns: table => new
                {
                    CodConsumoLavanderia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodConsumo1 = table.Column<int>(type: "int", nullable: true),
                    ServicoLavanderia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorServicoLavanderia = table.Column<double>(type: "float", nullable: false),
                    ValorConsumoLavanderia = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lavanderias", x => x.CodConsumoLavanderia);
                    table.ForeignKey(
                        name: "FK_Lavanderias_Consumos_CodConsumo1",
                        column: x => x.CodConsumo1,
                        principalTable: "Consumos",
                        principalColumn: "CodConsumo");
                });

            migrationBuilder.CreateTable(
                name: "Restaurantes",
                columns: table => new
                {
                    CodConsumoRestarante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodConsumo1 = table.Column<int>(type: "int", nullable: true),
                    ConsumoRestaurante = table.Column<double>(type: "float", nullable: false),
                    ConsumoFrigobar = table.Column<double>(type: "float", nullable: false),
                    ConsumoEntregaQuarto = table.Column<double>(type: "float", nullable: false),
                    TaxaEntregaQuarto = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurantes", x => x.CodConsumoRestarante);
                    table.ForeignKey(
                        name: "FK_Restaurantes_Consumos_CodConsumo1",
                        column: x => x.CodConsumo1,
                        principalTable: "Consumos",
                        principalColumn: "CodConsumo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckIns_CodCliente1",
                table: "CheckIns",
                column: "CodCliente1");

            migrationBuilder.CreateIndex(
                name: "IX_CheckOuts_CodCliente1",
                table: "CheckOuts",
                column: "CodCliente1");

            migrationBuilder.CreateIndex(
                name: "IX_Consumos_CodCheckIn",
                table: "Consumos",
                column: "CodCheckIn");

            migrationBuilder.CreateIndex(
                name: "IX_ContatosClientes_CodCliente1",
                table: "ContatosClientes",
                column: "CodCliente1");

            migrationBuilder.CreateIndex(
                name: "IX_Lavanderias_CodConsumo1",
                table: "Lavanderias",
                column: "CodConsumo1");

            migrationBuilder.CreateIndex(
                name: "IX_Quartos_CodHotel1",
                table: "Quartos",
                column: "CodHotel1");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_CodCliente1",
                table: "Reservas",
                column: "CodCliente1");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_CodFuncionario1",
                table: "Reservas",
                column: "CodFuncionario1");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_CodHotel1",
                table: "Reservas",
                column: "CodHotel1");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_NumeroQuarto1",
                table: "Reservas",
                column: "NumeroQuarto1");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurantes_CodConsumo1",
                table: "Restaurantes",
                column: "CodConsumo1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckOuts");

            migrationBuilder.DropTable(
                name: "ContatosClientes");

            migrationBuilder.DropTable(
                name: "Lavanderias");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Restaurantes");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Quartos");

            migrationBuilder.DropTable(
                name: "Consumos");

            migrationBuilder.DropTable(
                name: "Hoteis");

            migrationBuilder.DropTable(
                name: "CheckIns");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
