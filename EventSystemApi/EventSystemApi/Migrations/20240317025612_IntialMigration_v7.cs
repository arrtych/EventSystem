using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventSystemApi.Migrations
{
    /// <inheritdoc />
    public partial class IntialMigration_v7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonType",
                table: "Person",
                newName: "Discriminator");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Person",
                newName: "PersonType");
        }
    }
}
