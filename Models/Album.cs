using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiPrimerApi.Models
{
  [Table("AlbumesStock")]
  public class Album
  {
    [Column("album_id")]
    public int Id { get; set; }

    [MaxLength(10)]
    [Required]
    public string Nombre { get; set; }

    [Column("anio_publicacion")]
    [Range(1850, 2000)]
    public int AnioPublicacion { get; set; }
    public Artista Artista { get; set; }
  }
}