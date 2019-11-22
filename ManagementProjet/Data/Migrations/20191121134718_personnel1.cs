using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ManagementProjet.Data.Migrations
{
    public partial class personnel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personnel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Contrat = table.Column<int>(nullable: false),
                    DateNais = table.Column<DateTime>(nullable: false),
                    DateSortie = table.Column<DateTime>(nullable: false),
                    DebutC = table.Column<DateTime>(nullable: false),
                    Echelle = table.Column<string>(maxLength: 20, nullable: false),
                    Echelon = table.Column<string>(maxLength: 20, nullable: false),
                    FinC = table.Column<DateTime>(nullable: false),
                    Grade = table.Column<string>(maxLength: 20, nullable: false),
                    LieuNais = table.Column<string>(nullable: true),
                    MatCnss = table.Column<string>(nullable: true),
                    Nom = table.Column<string>(maxLength: 20, nullable: false),
                    NumCI = table.Column<string>(nullable: true),
                    PrimeCA = table.Column<decimal>(nullable: false),
                    Salaire = table.Column<decimal>(nullable: false),
                    Tache = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personnel");
        }
    }
}
