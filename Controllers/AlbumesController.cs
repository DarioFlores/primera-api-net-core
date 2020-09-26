using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MiPrimerApi.Models;
using System.Linq;
using MiPrimerApi.DataProvider;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlbumesController: ControllerBase
    {
        private MusicStoreContext context;
        private IAlbumesDataProvider provider = new AlbumesDataProviderFake();

        public AlbumesController(IAlbumesDataProvider albumesDataProvider, MusicStoreContext _context){
            provider = albumesDataProvider;
            context = _context;
        }


        [HttpGet]
        public List<Album> GetAlbums(){
            return context.Albumes.Include("Artista").ToList();
        }

        [HttpGet("{id:int}")]
        public ActionResult<Album> GetAlbum(int id){
            var album = context.Albumes.Include("Artista").FirstOrDefault( album => album.Id == id);
            return Ok(album);
        }

        [HttpPost]
        public ActionResult<List<Album>> AddAlbum(Album album){
            context.Albumes.Add(album);
            return Ok(provider.GetAll());
        }

        [HttpPut("{id:int}")]
        public ActionResult<List<Album>> UpdateAlbum(int id, [FromBody] Album album){
            provider.UpdateAlbum(id, album);
            return Ok(provider.GetAll());

        }
    }
}