using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birims",
                columns: table => new
                {
                    BirimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirimAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirimKod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birims", x => x.BirimId);
                });

            migrationBuilder.CreateTable(
                name: "Unvans",
                columns: table => new
                {
                    UnvanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unvani = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unvans", x => x.UnvanId);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sicil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnvanId = table.Column<int>(type: "int", nullable: true),
                    BirimId = table.Column<int>(type: "int", nullable: true),
                    DahiliTelefonu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CepTelefonu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_Personels_Birims_BirimId",
                        column: x => x.BirimId,
                        principalTable: "Birims",
                        principalColumn: "BirimId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personels_Unvans_UnvanId",
                        column: x => x.UnvanId,
                        principalTable: "Unvans",
                        principalColumn: "UnvanId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personels_BirimId",
                table: "Personels",
                column: "BirimId");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_UnvanId",
                table: "Personels",
                column: "UnvanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Birims");

            migrationBuilder.DropTable(
                name: "Unvans");
        }
    }
}
