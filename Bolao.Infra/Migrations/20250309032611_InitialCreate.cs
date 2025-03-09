using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bolao.Infra.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Pontuacao = table.Column<int>(type: "INTEGER", nullable: false),
                    DistanciaPontuacao = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rodadas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Numero = table.Column<int>(type: "INTEGER", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rodadas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "INTEGER", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoPontuacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JogadorId = table.Column<int>(type: "INTEGER", nullable: false),
                    RodadaId = table.Column<int>(type: "INTEGER", nullable: false),
                    PontuacaoRodada = table.Column<int>(type: "INTEGER", nullable: false),
                    DPRodada = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoPontuacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoPontuacoes_Jogadores_JogadorId",
                        column: x => x.JogadorId,
                        principalTable: "Jogadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoricoPontuacoes_Rodadas_RodadaId",
                        column: x => x.RodadaId,
                        principalTable: "Rodadas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jogos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RodadaId = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeCasaId = table.Column<byte>(type: "INTEGER", nullable: false),
                    TimeVisitanteId = table.Column<byte>(type: "INTEGER", nullable: false),
                    GolsTimeCasa = table.Column<int>(type: "INTEGER", nullable: true),
                    GolsTimeVisitante = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jogos_Rodadas_RodadaId",
                        column: x => x.RodadaId,
                        principalTable: "Rodadas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jogos_Times_TimeCasaId",
                        column: x => x.TimeCasaId,
                        principalTable: "Times",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jogos_Times_TimeVisitanteId",
                        column: x => x.TimeVisitanteId,
                        principalTable: "Times",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Palpites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JogadorId = table.Column<int>(type: "INTEGER", nullable: false),
                    JogoId = table.Column<int>(type: "INTEGER", nullable: false),
                    PalpiteGolsTimeCasa = table.Column<int>(type: "INTEGER", nullable: false),
                    PalpiteGolsTimeFora = table.Column<int>(type: "INTEGER", nullable: false),
                    Pontuacao = table.Column<int>(type: "INTEGER", nullable: false),
                    DistanciaPontuacao = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palpites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Palpites_Jogadores_JogadorId",
                        column: x => x.JogadorId,
                        principalTable: "Jogadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Palpites_Jogos_JogoId",
                        column: x => x.JogoId,
                        principalTable: "Jogos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoPontuacoes_JogadorId",
                table: "HistoricoPontuacoes",
                column: "JogadorId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoPontuacoes_RodadaId",
                table: "HistoricoPontuacoes",
                column: "RodadaId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_RodadaId",
                table: "Jogos",
                column: "RodadaId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_TimeCasaId",
                table: "Jogos",
                column: "TimeCasaId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_TimeVisitanteId",
                table: "Jogos",
                column: "TimeVisitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Palpites_JogadorId",
                table: "Palpites",
                column: "JogadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Palpites_JogoId",
                table: "Palpites",
                column: "JogoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricoPontuacoes");

            migrationBuilder.DropTable(
                name: "Palpites");

            migrationBuilder.DropTable(
                name: "Jogadores");

            migrationBuilder.DropTable(
                name: "Jogos");

            migrationBuilder.DropTable(
                name: "Rodadas");

            migrationBuilder.DropTable(
                name: "Times");
        }
    }
}
