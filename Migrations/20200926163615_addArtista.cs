using Microsoft.EntityFrameworkCore.Migrations;

namespace MiPrimerApi.Migrations
{
    public partial class addArtista : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlbumesStock_Artista_ArtistaId",
                table: "AlbumesStock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artista",
                table: "Artista");

            migrationBuilder.RenameTable(
                name: "Artista",
                newName: "Artistas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artistas",
                table: "Artistas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumesStock_Artistas_ArtistaId",
                table: "AlbumesStock",
                column: "ArtistaId",
                principalTable: "Artistas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlbumesStock_Artistas_ArtistaId",
                table: "AlbumesStock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artistas",
                table: "Artistas");

            migrationBuilder.RenameTable(
                name: "Artistas",
                newName: "Artista");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artista",
                table: "Artista",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumesStock_Artista_ArtistaId",
                table: "AlbumesStock",
                column: "ArtistaId",
                principalTable: "Artista",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
