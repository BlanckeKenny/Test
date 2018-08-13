using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EE.Beers.Migrations
{
    public partial class AddedBrewery1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Brouwerijen_BrouwerijForeignKey",
                table: "Beers");

            migrationBuilder.DropIndex(
                name: "IX_Beers_BrouwerijForeignKey",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "BrouwerijForeignKey",
                table: "Beers");

            migrationBuilder.AddColumn<long>(
                name: "BrouwerijId",
                table: "Beers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Beers_BrouwerijId",
                table: "Beers",
                column: "BrouwerijId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_Brouwerijen_BrouwerijId",
                table: "Beers",
                column: "BrouwerijId",
                principalTable: "Brouwerijen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Brouwerijen_BrouwerijId",
                table: "Beers");

            migrationBuilder.DropIndex(
                name: "IX_Beers_BrouwerijId",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "BrouwerijId",
                table: "Beers");

            migrationBuilder.AddColumn<long>(
                name: "BrouwerijForeignKey",
                table: "Beers",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Beers_BrouwerijForeignKey",
                table: "Beers",
                column: "BrouwerijForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_Brouwerijen_BrouwerijForeignKey",
                table: "Beers",
                column: "BrouwerijForeignKey",
                principalTable: "Brouwerijen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
