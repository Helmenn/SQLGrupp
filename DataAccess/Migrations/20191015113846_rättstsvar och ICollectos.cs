using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class rättstsvarochICollectos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RättatSvar",
                columns: table => new
                {
                    RättatSvarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SvarID = table.Column<int>(nullable: false),
                    SvaraltID = table.Column<int>(nullable: false),
                    Rätt = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RättatSvar", x => x.RättatSvarID);
                    table.ForeignKey(
                        name: "FK_RättatSvar_Svar_SvarID",
                        column: x => x.SvarID,
                        principalTable: "Svar",
                        principalColumn: "SvarID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RättatSvar_Svaralt_SvaraltID",
                        column: x => x.SvaraltID,
                        principalTable: "Svaralt",
                        principalColumn: "SvaraltID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RättatSvar_SvarID",
                table: "RättatSvar",
                column: "SvarID");

            migrationBuilder.CreateIndex(
                name: "IX_RättatSvar_SvaraltID",
                table: "RättatSvar",
                column: "SvaraltID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RättatSvar");
        }
    }
}
