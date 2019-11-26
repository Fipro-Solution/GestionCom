using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ManagementProjet.Data.Migrations
{
    public partial class Client : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: false),
                    Douleurs = table.Column<bool>(nullable: false),
                    EmailCon = table.Column<string>(nullable: false),
                    Fax = table.Column<string>(nullable: false),
                    FaxContact = table.Column<string>(nullable: false),
                    FoncContact = table.Column<string>(nullable: false),
                    GsmContact = table.Column<string>(nullable: false),
                    Libelle = table.Column<string>(nullable: false),
                    MatFisc = table.Column<string>(nullable: false),
                    NomContact = table.Column<string>(nullable: false),
                    Remarque = table.Column<string>(nullable: true),
                    Siteweb = table.Column<string>(nullable: true),
                    TauxTva = table.Column<int>(nullable: false),
                    Tel = table.Column<string>(nullable: false),
                    TelContact = table.Column<string>(nullable: false),
                    TypeClt = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
