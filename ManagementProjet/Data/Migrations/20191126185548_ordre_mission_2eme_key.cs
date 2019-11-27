using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ManagementProjet.Data.Migrations
{
    public partial class ordre_mission_2eme_key : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
