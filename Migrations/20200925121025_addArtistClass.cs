using Microsoft.EntityFrameworkCore.Migrations;

namespace MiPrimerApi.Migrations
{
    public partial class addArtistClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Albumes",
                table: "Albumes");

            migrationBuilder.DropColumn(
                name: "Artista",
                table: "Albumes");

            migrationBuilder.RenameTable(
                name: "Albumes",
                newName: "AlbumesStock");

            migrationBuilder.RenameColumn(
                name: "AnioPublicacion",
                table: "AlbumesStock",
                newName: "anio_publicacion");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AlbumesStock",
                newName: "album_id");

            migrationBuilder.AddColumn<int>(
                name: "ArtistaId",
                table: "AlbumesStock",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlbumesStock",
                table: "AlbumesStock",
                column: "album_id");

            migrationBuilder.CreateTable(
                name: "Artista",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnioNacimiento = table.Column<int>(nullable: false),
                    Nacionalidad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artista", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumesStock_ArtistaId",
                table: "AlbumesStock",
                column: "ArtistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumesStock_Artista_ArtistaId",
                table: "AlbumesStock",
                column: "ArtistaId",
                principalTable: "Artista",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlbumesStock_Artista_ArtistaId",
                table: "AlbumesStock");

            migrationBuilder.DropTable(
                name: "Artista");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlbumesStock",
                table: "AlbumesStock");

            migrationBuilder.DropIndex(
                name: "IX_AlbumesStock_ArtistaId",
                table: "AlbumesStock");

            migrationBuilder.DropColumn(
                name: "ArtistaId",
                table: "AlbumesStock");

            migrationBuilder.RenameTable(
                name: "AlbumesStock",
                newName: "Albumes");

            migrationBuilder.RenameColumn(
                name: "anio_publicacion",
                table: "Albumes",
                newName: "AnioPublicacion");

            migrationBuilder.RenameColumn(
                name: "album_id",
                table: "Albumes",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Artista",
                table: "Albumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Albumes",
                table: "Albumes",
                column: "Id");
        }
    }
}
