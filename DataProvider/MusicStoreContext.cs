using Microsoft.EntityFrameworkCore;
using MiPrimerApi.Models;
using System.Collections.Generic;

namespace MiPrimerApi.DataProvider
{
    public class MusicStoreContext : DbContext
    {
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        //     optionsBuilder.UseSqlServer(@"Server=.\sqlexpress; Initial Catalog=MusicStore;Integrated Security=True");
        // }

        public MusicStoreContext(DbContextOptions options) : base(options){
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Artista>().HasData(new List<Artista>(){
                new Artista(){
                    AnioNacimiento = 1886,
                    Nacionalidad = "Argentina",
                    Id = 1
                }
            });
            modelBuilder.Entity<Album>().HasData(new List<Album>(){
                new Album(){
                    AnioPublicacion = 2011,
                    Nombre = "Lala",
                    Id = 1,
                    ArtistaId = 1
                }
            });
        }
        public DbSet<Album> Albumes { get; set; }
        public DbSet<Artista> Artistas { get; set; }
    }
}