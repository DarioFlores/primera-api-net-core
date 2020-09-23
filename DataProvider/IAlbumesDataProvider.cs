using System.Collections.Generic;
using MiPrimerApi.Models;


namespace MiPrimerApi.DataProvider
{
    public interface IAlbumesDataProvider
    {
        long Ticks { get; set; }
        List<Album> GetAll();
        Album GetAlbum(int id);
        void AddAlbum(Album album);
        void UpdateAlbum(int id, Album album);
    }
}