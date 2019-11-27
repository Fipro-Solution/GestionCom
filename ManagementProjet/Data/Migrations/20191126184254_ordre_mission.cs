using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ManagementProjet.Data.Migrations
{
    public partial class ordre_mission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrdreMission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CIN = table.Column<int>(nullable: true),
                    Code = table.Column<string>(nullable: false),
                    CompteurFinal = table.Column<int>(nullable: false),
                    CompteurInit = table.Column<int>(nullable: false),
                    DateDepart = table.Column<DateTime>(nullable: false),
                    DateMission = table.Column<DateTime>(nullable: false),
                    DateRetour = table.Column<DateTime>(nullable: false),
                    Destinations = table.Column<string>(maxLength: 20, nullable: false),
                    DetailsMission = table.Column<string>(maxLength: 1000, nullable: false),
                    FraisMission1 = table.Column<float>(nullable: true),
                    FraisMission2 = table.Column<float>(nullable: true),
                    FraisMission3 = table.Column<float>(nullable: true),
                    LibelleMission1 = table.Column<string>(nullable: false),
                    LibelleMission2 = table.Column<string>(nullable: true),
                    LibelleMission3 = table.Column<string>(nullable: true),
                    NumPermis = table.Column<string>(maxLength: 20, nullable: false),
                    VehiculeId = table.Column<int>(nullable: false),
                    matricule = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdreMission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdreMission_Vehicule_VehiculeId",
                        column: x => x.VehiculeId,
                        principalTable: "Vehicule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdreMission_VehiculeId",
                table: "OrdreMission",
                column: "VehiculeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdreMission");
        }
    }
}
