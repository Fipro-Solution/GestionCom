using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ManagementProjet.Data.Migrations
{
    public partial class Agence : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agence",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccidentTravail = table.Column<float>(nullable: false),
                    Address = table.Column<string>(maxLength: 20, nullable: false),
                    AdrsUrl = table.Column<string>(nullable: true),
                    Cnss = table.Column<string>(nullable: true),
                    CnssEmployeur = table.Column<float>(nullable: false),
                    Contact = table.Column<string>(maxLength: 20, nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Fiprolos = table.Column<float>(nullable: false),
                    GsmContact = table.Column<string>(nullable: true),
                    MatCNSS = table.Column<string>(nullable: true),
                    MatFiscale = table.Column<string>(maxLength: 20, nullable: false),
                    Smigar = table.Column<string>(maxLength: 20, nullable: true),
                    Tel = table.Column<string>(nullable: false),
                    TelContact = table.Column<string>(nullable: true),
                    Telecopie = table.Column<string>(nullable: true),
                    Tfp = table.Column<float>(nullable: false),
                    capital = table.Column<decimal>(nullable: false),
                    code = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    libelle = table.Column<string>(maxLength: 20, nullable: false),
                    proprietaire = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agence", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agence");
        }
    }
}
