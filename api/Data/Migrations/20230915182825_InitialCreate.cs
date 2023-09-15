using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgrammingLevel = table.Column<int>(type: "int", nullable: false),
                    ProgrammingXP = table.Column<int>(type: "int", nullable: false),
                    FitnessLevel = table.Column<int>(type: "int", nullable: false),
                    FitnessXP = table.Column<int>(type: "int", nullable: false),
                    HouseworkLevel = table.Column<int>(type: "int", nullable: false),
                    HouseworkXP = table.Column<int>(type: "int", nullable: false),
                    ReadingLevel = table.Column<int>(type: "int", nullable: false),
                    ReadingXP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
