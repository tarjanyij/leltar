using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace leltar.Migrations
{
    public partial class Databaseexpand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nev",
                table: "InventoryDatas",
                newName: "Vonalkod");

            migrationBuilder.AddColumn<int>(
                name: "BruttoErtek",
                table: "InventoryDatas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ElhelyezesIdeje",
                table: "InventoryDatas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EszkozAzon",
                table: "InventoryDatas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "HasznalatbaVetelDatuma",
                table: "InventoryDatas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LeltSzemely",
                table: "InventoryDatas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LeltSzemelyNeve",
                table: "InventoryDatas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeltarKorzetMegnevezes",
                table: "InventoryDatas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Mennyiseg",
                table: "InventoryDatas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BruttoErtek",
                table: "InventoryDatas");

            migrationBuilder.DropColumn(
                name: "ElhelyezesIdeje",
                table: "InventoryDatas");

            migrationBuilder.DropColumn(
                name: "EszkozAzon",
                table: "InventoryDatas");

            migrationBuilder.DropColumn(
                name: "HasznalatbaVetelDatuma",
                table: "InventoryDatas");

            migrationBuilder.DropColumn(
                name: "LeltSzemely",
                table: "InventoryDatas");

            migrationBuilder.DropColumn(
                name: "LeltSzemelyNeve",
                table: "InventoryDatas");

            migrationBuilder.DropColumn(
                name: "LeltarKorzetMegnevezes",
                table: "InventoryDatas");

            migrationBuilder.DropColumn(
                name: "Mennyiseg",
                table: "InventoryDatas");

            migrationBuilder.RenameColumn(
                name: "Vonalkod",
                table: "InventoryDatas",
                newName: "Nev");
        }
    }
}
