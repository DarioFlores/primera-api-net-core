using System.Collections.Generic;
using MiPrimerApi.Models;
using System.Linq;
using System;

namespace MiPrimerApi.DataProvider
{
    public class AlbumesDataProviderFake : IAlbumesDataProvider
    {
        public AlbumesDataProviderFake(){
            Ticks = DateTime.Now.Ticks;
        }

        
        private List<Album> Albumes = new List<Album>();
        // {
        //     new Album(){
        //         Id = 1,
        //         AnioPublicacion = 2016,
        //         Artista = "Arjona",
        //         Nombre = "5to Piso", 
        //     },
        //     new Album(){
        //         Id = 2,
        //         AnioPublicacion = 2006,
        //         Artista = "Adres Calamaro",
        //         Nombre = "El Salmon", 
        //     },
        // };

    public long Ticks { get; set; }

    public List<Album> GetAll(){
            return Albumes;
        }

        public Album GetAlbum(int id){
            return Albumes.FirstOrDefault<Album>( album => album.Id == id);
        }

        public void AddAlbum(Album album){
            Albumes.Add(album);
        }

        public void UpdateAlbum(int id, Album album){
            var item = this.GetAlbum(id);
            item.AnioPublicacion = album.AnioPublicacion;
            item.Artista = album.Artista;
            item.Nombre = album.Nombre;
        }
    }
}