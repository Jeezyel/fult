namespace fult.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;


    internal sealed class Configuration : DbMigrationsConfiguration<TimeFutebol.TimeFutebolDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TimeFutebol.TimeFutebolDBContext context)
        {
            protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Criação da tabela TimeFutebol
            migrationBuilder.CreateTable(
                name: "TimeFutebol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    AnoFundacao = table.Column<int>(nullable: false),
                    Estadio = table.Column<string>(nullable: true),
                    CapacidadeEstadio = table.Column<int>(nullable: false),
                    CorPrimaria = table.Column<string>(nullable: true),
                    CorSecundaria = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeFutebol", x => x.Id);
                });

            // Criação da tabela Jogador
            migrationBuilder.CreateTable(
                name: "Jogador",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Nacionalidade = table.Column<string>(nullable: true),
                    Posicao = table.Column<int>(nullable: false),
                    NumeroCamisa = table.Column<int>(nullable: false),
                    Altura = table.Column<double>(nullable: false),
                    Peso = table.Column<double>(nullable: false),
                    PePreferido = table.Column<int>(nullable: false),
                    TimeFutebolId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jogador_TimeFutebol_TimeFutebolId",
                        column: x => x.TimeFutebolId,
                        principalTable: "TimeFutebol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            // Criação da tabela ComissaoTecnica
            migrationBuilder.CreateTable(
                name: "ComissaoTecnica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Cargo = table.Column<int>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    TimeFutebolId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComissaoTecnica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComissaoTecnica_TimeFutebol_TimeFutebolId",
                        column: x => x.TimeFutebolId,
                        principalTable: "TimeFutebol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            // Criação da tabela Partida
            migrationBuilder.CreateTable(
                name: "Partida",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataHora = table.Column<DateTime>(nullable: false),
                    Estadio = table.Column<string>(nullable: true),
                    TimeMandanteId = table.Column<int>(nullable: false),
                    TimeVisitanteId = table.Column<int>(nullable: false),
                    GolsMandante = table.Column<int>(nullable: false),
                    GolsVisitante = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partida", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partida_TimeFutebol_TimeMandanteId",
                        column: x => x.TimeMandanteId,
                        principalTable: "TimeFutebol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Partida_TimeFutebol_TimeVisitanteId",
                        column: x => x.TimeVisitanteId,
                        principalTable: "TimeFutebol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComissaoTecnica");

            migrationBuilder.DropTable(
                name: "Jogador");

            migrationBuilder.DropTable(
                name: "Partida");

            migrationBuilder.DropTable(
                name: "TimeFutebol");
        }
    }
    }
}
