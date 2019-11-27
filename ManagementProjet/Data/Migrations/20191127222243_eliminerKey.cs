using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ManagementProjet.Data.Migrations
{
    public partial class eliminerKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdreMission_Personnel_PersonnelId",
                table: "OrdreMission");

            migrationBuilder.DropIndex(
                name: "IX_OrdreMission_PersonnelId",
                table: "OrdreMission");

            migrationBuilder.DropColumn(
                name: "PersonnelId",
                table: "OrdreMission");

            migrationBuilder.AddColumn<string>(
                name: "Conducteur",
                table: "OrdreMission",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "Total",
                table: "OrdreMission",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conducteur",
                table: "OrdreMission");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "OrdreMission");

            migrationBuilder.AddColumn<int>(
                name: "PersonnelId",
                table: "OrdreMission",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrdreMission_PersonnelId",
                table: "OrdreMission",
                column: "PersonnelId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdreMission_Personnel_PersonnelId",
                table: "OrdreMission",
                column: "PersonnelId",
                principalTable: "Personnel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
