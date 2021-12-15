using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategoriID",
                table: "Takviyelers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Takviyelers_KategoriID",
                table: "Takviyelers",
                column: "KategoriID");

            migrationBuilder.AddForeignKey(
                name: "FK_Takviyelers_Kategoris_KategoriID",
                table: "Takviyelers",
                column: "KategoriID",
                principalTable: "Kategoris",
                principalColumn: "KategoriID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Takviyelers_Kategoris_KategoriID",
                table: "Takviyelers");

            migrationBuilder.DropIndex(
                name: "IX_Takviyelers_KategoriID",
                table: "Takviyelers");

            migrationBuilder.DropColumn(
                name: "KategoriID",
                table: "Takviyelers");
        }
    }
}
