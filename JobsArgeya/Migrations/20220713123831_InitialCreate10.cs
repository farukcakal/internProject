﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace JobsArgeya.Migrations
{
    public partial class InitialCreate10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "jobSlug",
                table: "Applies");

            migrationBuilder.AddColumn<int>(
                name: "jobId",
                table: "Applies",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "jobId",
                table: "Applies");

            migrationBuilder.AddColumn<string>(
                name: "jobSlug",
                table: "Applies",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
