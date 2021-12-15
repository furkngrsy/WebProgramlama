using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_yorumtakviye : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TakviyeID",
                table: "Yorumlars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TakviyelerTakviyeID",
                table: "Yorumlars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlars_TakviyelerTakviyeID",
                table: "Yorumlars",
                column: "TakviyelerTakviyeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Yorumlars_Takviyelers_TakviyelerTakviyeID",
                table: "Yorumlars",
                column: "TakviyelerTakviyeID",
                principalTable: "Takviyelers",
                principalColumn: "TakviyeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yorumlars_Takviyelers_TakviyelerTakviyeID",
                table: "Yorumlars");

            migrationBuilder.DropIndex(
                name: "IX_Yorumlars_TakviyelerTakviyeID",
                table: "Yorumlars");

            migrationBuilder.DropColumn(
                name: "TakviyeID",
                table: "Yorumlars");

            migrationBuilder.DropColumn(
                name: "TakviyelerTakviyeID",
                table: "Yorumlars");
        }
    }
}
