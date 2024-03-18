﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventSystemApi.Migrations
{
    /// <inheritdoc />
    public partial class db_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Events_EventId",
                table: "Person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_EventId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "JuridicalName",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "ParticipantsAmount",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "RegisterCode",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "PrivatePersons");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "PrivatePersons",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "PrivatePersons",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrivatePersons",
                table: "PrivatePersons",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JuridicalName = table.Column<string>(type: "TEXT", nullable: false),
                    RegisterCode = table.Column<string>(type: "TEXT", nullable: false),
                    ParticipantsAmount = table.Column<int>(type: "INTEGER", nullable: false),
                    Info = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: true),
                    PaymentType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrivatePersons",
                table: "PrivatePersons");

            migrationBuilder.RenameTable(
                name: "PrivatePersons",
                newName: "Person");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Person",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Person",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Person",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Person",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "JuridicalName",
                table: "Person",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParticipantsAmount",
                table: "Person",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegisterCode",
                table: "Person",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Person_EventId",
                table: "Person",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Events_EventId",
                table: "Person",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
