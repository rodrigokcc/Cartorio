using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cartorio.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Casamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataDoRegistro = table.Column<DateTime>(type: "date", nullable: false),
                    DataDoCasamento = table.Column<DateTime>(type: "date", nullable: false),
                    NomeConjuge1 = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    DataDeNascimentoConjuge1 = table.Column<DateTime>(type: "date", nullable: false),
                    CpfConjuge1 = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    NomeDoPaiConjuge1 = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    NomeDaMaeConjuge1 = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    DataDeNascimentoDoPaiConjuge1 = table.Column<DateTime>(type: "date", nullable: true),
                    DataDeNascimentoDaMaeConjuge1 = table.Column<DateTime>(type: "date", nullable: true),
                    CpfDoPaiConjuge1 = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: true),
                    CpfDaMaeConjuge1 = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: true),
                    NomeConjuge2 = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    DataDeNascimentoConjuge2 = table.Column<DateTime>(type: "date", nullable: false),
                    CpfConjuge2 = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    NomeDoPaiConjuge2 = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    NomeDaMaeConjuge2 = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    DataDeNascimentoDoPaiConjuge2 = table.Column<DateTime>(type: "date", nullable: true),
                    DataDeNascimentoDaMaeConjuge2 = table.Column<DateTime>(type: "date", nullable: true),
                    CpfDoPaiConjuge2 = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: true),
                    CpfDaMaeConjuge2 = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nascimentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataDoRegistro = table.Column<DateTime>(type: "date", nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "date", nullable: false),
                    NomeDoRegistrado = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    NomeDoPai = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    NomeDaMae = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    DataDeNascimentoDoPai = table.Column<DateTime>(type: "date", nullable: true),
                    DataDeNascimentoDaMae = table.Column<DateTime>(type: "date", nullable: true),
                    CpfDoPai = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: true),
                    CpfDaMae = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nascimentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Obitos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataDoRegistro = table.Column<DateTime>(type: "date", nullable: false),
                    DataDoObito = table.Column<DateTime>(type: "date", nullable: false),
                    NomeDoFalecido = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "date", nullable: false),
                    NomeDoPai = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    NomeDaMae = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    DataDeNascimentoDoPai = table.Column<DateTime>(type: "date", nullable: true),
                    DataDeNascimentoDaMae = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obitos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Casamentos");

            migrationBuilder.DropTable(
                name: "Nascimentos");

            migrationBuilder.DropTable(
                name: "Obitos");
        }
    }
}
