using Microsoft.EntityFrameworkCore.Migrations;

namespace MiPrimerApi.Migrations
{
    public partial class addInitialAlbum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlbumesStock_Artistas_ArtistaId",
                table: "AlbumesStock");

            migrationBuilder.AlterColumn<int>(
                name: "ArtistaId",
                table: "AlbumesStock",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Artistas",
                columns: new[] { "Id", "AnioNacimiento", "Nacionalidad" },
                values: new object[] { 1, 1886, "Argentina" });

            migrationBuilder.InsertData(
                table: "AlbumesStock",
                columns: new[] { "album_id", "anio_publicacion", "ArtistaId", "Nombre" },
                values: new object[] { 1, 2011, 1, "Lala" });

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumesStock_Artistas_ArtistaId",
                table: "AlbumesStock",
                column: "ArtistaId",
                principalTable: "Artistas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlbumesStock_Artistas_ArtistaId",
                table: "AlbumesStock");

            migrationBuilder.DeleteData(
                table: "AlbumesStock",
                keyColumn: "album_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "ArtistaId",
                table: "AlbumesStock",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumesStock_Artistas_ArtistaId",
                table: "AlbumesStock",
                column: "ArtistaId",
                principalTable: "Artistas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
