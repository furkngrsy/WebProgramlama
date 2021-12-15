using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hakkindas",
                columns: table => new
                {
                    HakkindaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HakkindaDetay1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkindaDetay2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkindaFoto1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkindaFoto2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkindas", x => x.HakkindaID);
                });

            migrationBuilder.CreateTable(
                name: "Iletisims",
                columns: table => new
                {
                    IletisimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IletisimKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimKonu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimMesaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IletisimDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisims", x => x.IletisimID);
                });

            migrationBuilder.CreateTable(
                name: "Kategoris",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoris", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciSifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.KullaniciID);
                });

            migrationBuilder.CreateTable(
                name: "Takviyelers",
                columns: table => new
                {
                    TakviyeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakviyeAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TakviyeFiyat = table.Column<int>(type: "int", nullable: false),
                    TakviyeKucukFoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TakviyeFoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TakviyeAroma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TakviyeAdet = table.Column<int>(type: "int", nullable: false),
                    TakviyeDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takviyelers", x => x.TakviyeID);
                });

            migrationBuilder.CreateTable(
                name: "Yorumlars",
                columns: table => new
                {
                    YorumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YorumKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumIcerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YorumDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumlars", x => x.YorumID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hakkindas");

            migrationBuilder.DropTable(
                name: "Iletisims");

            migrationBuilder.DropTable(
                name: "Kategoris");

            migrationBuilder.DropTable(
                name: "Kullanicis");

            migrationBuilder.DropTable(
                name: "Takviyelers");

            migrationBuilder.DropTable(
                name: "Yorumlars");
        }
    }
}
