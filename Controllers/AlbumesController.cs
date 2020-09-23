using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MiPrimerApi.Models;
using MiPrimerApi.DataProvider;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlbumesController: ControllerBase
    {

        public AlbumesController(IAlbumesDataProvider albumesDataProvider){
            provider = albumesDataProvider;
        }

        private IAlbumesDataProvider provider = new AlbumesDataProviderFake();

        [HttpGet("tick")]
        public long GetTicks(){
            return provider.Ticks;
        }


        [HttpGet]
        public List<Album> GetAlbums(){
            return provider.GetAll();
        }

        [HttpGet("{id:int}")]
        public ActionResult<Album> GetAlbum(int id){
            if (id < 2)
            {
                return Ok(provider.GetAlbum(id));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<List<Album>> AddAlbum(Album album){
            provider.AddAlbum(album);
            return Ok(provider.GetAll());
        }

        [HttpPut("{id:int}")]
        public ActionResult<List<Album>> UpdateAlbum(int id, [FromBody] Album album){
            provider.UpdateAlbum(id, album);
            return Ok(provider.GetAll());

        }
    }
}