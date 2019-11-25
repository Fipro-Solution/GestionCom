using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ManagementProjet.Data.Migrations
{
    public partial class Vehicule1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ARD = table.Column<string>(nullable: true),
                    ARG = table.Column<string>(nullable: true),
                    AVD = table.Column<string>(nullable: true),
                    AVG = table.Column<string>(nullable: true),
                    Abs = table.Column<bool>(nullable: true),
                    Accessoire = table.Column<string>(nullable: true),
                    Actif = table.Column<bool>(nullable: true),
                    Airbag = table.Column<bool>(nullable: true),
                    Alarme = table.Column<bool>(nullable: true),
                    Amortis = table.Column<int>(nullable: true),
                    Assise = table.Column<string>(nullable: true),
                    Categorie = table.Column<string>(nullable: false),
                    Code = table.Column<int>(nullable: false),
                    Commandeadistance = table.Column<bool>(nullable: true),
                    Couleur = table.Column<string>(nullable: true),
                    Cylindree = table.Column<int>(nullable: true),
                    DateAcqui = table.Column<DateTime>(nullable: true),
                    DateFinG = table.Column<DateTime>(nullable: true),
                    DatePMC = table.Column<DateTime>(nullable: true),
                    Debout = table.Column<string>(nullable: true),
                    DemarrageCode = table.Column<bool>(nullable: true),
                    Demarrageadistance = table.Column<bool>(nullable: true),
                    DirectionAssiste = table.Column<bool>(nullable: true),
                    Energie = table.Column<int>(nullable: false),
                    Etat = table.Column<int>(nullable: false),
                    FermetureCentrale = table.Column<bool>(nullable: true),
                    Fourn = table.Column<string>(nullable: true),
                    IndKilimetre = table.Column<int>(nullable: true),
                    JanteAllu = table.Column<bool>(nullable: true),
                    Libelle = table.Column<string>(nullable: false),
                    MantAcqui = table.Column<decimal>(nullable: true),
                    Marque = table.Column<string>(nullable: false),
                    Modele = table.Column<string>(nullable: false),
                    NMoteur = table.Column<string>(nullable: true),
                    Nchassis = table.Column<string>(nullable: true),
                    Observation = table.Column<string>(maxLength: 1000, nullable: true),
                    PoidsUtile = table.Column<float>(nullable: true),
                    PoidsVide = table.Column<float>(nullable: true),
                    Pratique = table.Column<decimal>(nullable: true),
                    Radio = table.Column<bool>(nullable: true),
                    RadioCD = table.Column<bool>(nullable: true),
                    Restant = table.Column<decimal>(nullable: true),
                    Saloncuir = table.Column<bool>(nullable: true),
                    Secour = table.Column<string>(nullable: true),
                    SiegePilote = table.Column<bool>(nullable: true),
                    Taxe = table.Column<decimal>(nullable: true),
                    Vendue = table.Column<bool>(nullable: true),
                    climatise = table.Column<bool>(nullable: true),
                    immatricule = table.Column<string>(nullable: false),
                    puissance = table.Column<string>(nullable: true),
                    theorique = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicule", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicule");
        }
    }
}
