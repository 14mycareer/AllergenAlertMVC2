using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AllergenAlertMVC2.Migrations
{
    public partial class allergencolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NoAllergen",
                table: "Restaurants",
                newName: "Nuts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nuts",
                table: "Restaurants",
                newName: "NoAllergen");
        }
    }
}
