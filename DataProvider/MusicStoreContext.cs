using Microsoft.EntityFrameworkCore;
using MiPrimerApi.Models;
namespace DataProvider
{
    public class MusicStoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(@"Server=.\sqlexpress; Initial Catalog=MusicStore;Integrated Security=True");
        }
        public DbSet<Album> Albumes { get; set; }
        public DbSet<Artista> Artistas { get; set; }
    }
}