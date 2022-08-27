using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokeDex.Data.Db.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    EvolvesFromPokemonId = table.Column<int>(type: "int", nullable: false),
                    evolvesToPokemonId = table.Column<int>(type: "int", nullable: false),
                    EvolvesToPokemonId = table.Column<int>(type: "int", nullable: false),
                    evolvesFromPokemonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.PokemonId);
                    table.ForeignKey(
                        name: "FK_Pokemon_Pokemon_evolvesToPokemonId",
                        column: x => x.evolvesToPokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "PokemonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "PokemonType",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonType", x => new { x.PokemonId, x.TypeId });
                    table.ForeignKey(
                        name: "FK_PokemonType_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "PokemonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonType_Type_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Type",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "TypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Normal" },
                    { 2, "Fire" },
                    { 3, "Water" },
                    { 4, "Grass" },
                    { 5, "Electric" },
                    { 6, "Ice" },
                    { 7, "Fighting" },
                    { 8, "Poison" },
                    { 9, "Ground" },
                    { 10, "Flying" },
                    { 11, "Psychic" },
                    { 12, "Bug" },
                    { 13, "Rock" },
                    { 14, "Ghost" },
                    { 15, "Dark" },
                    { 16, "Dragon" },
                    { 17, "Steel" },
                    { 18, "Fairy" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_evolvesToPokemonId",
                table: "Pokemon",
                column: "evolvesToPokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonType_TypeId",
                table: "PokemonType",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonType");

            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "Type");
        }
    }
}
