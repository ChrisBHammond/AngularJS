using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using API.Repository;
using Models;

namespace API.Controllers
{
    public class VideoGamesController : ApiController
    {
        private VideoGameRepository repo = new VideoGameRepository();

        // GET: api/VideoGames
        [HttpGet]
        [Route("api/{videoGames}/")]
        public IQueryable<VideoGame> GetVideoGames()
        {
            return repo.GetVideoGames();
        }

        // GET: api/VideoGames/5
        [ResponseType(typeof(VideoGame))]
        [HttpGet]
        [Route("api/{GetVideoGameById}/{id}")]
        public IHttpActionResult GetVideoGame(int id)
        {
            var videoGame = repo.GetVideoGameByID(id);
            if (videoGame == null)
            {
                return NotFound();
            }

            return Ok(videoGame);
        }

        // PUT: api/VideoGames/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVideoGame(VideoGame videoGame)
        {
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: api/VideoGames
        [ResponseType(typeof(VideoGame))]
        [Route("api/{UpdateVideoGame}/")]
        public IHttpActionResult PostVideoGame(VideoGame videoGame)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            repo.updateVideoGame(videoGame);

            return StatusCode(HttpStatusCode.OK);
        }

        // DELETE: api/VideoGames/5
        [ResponseType(typeof(VideoGame))]
        public IHttpActionResult DeleteVideoGame(int id)
        {
            //VideoGame videoGame = db.VideoGames.Find(id);
            //if (videoGame == null)
            //{
            //    return NotFound();
            //}

            //db.VideoGames.Remove(videoGame);
            //db.SaveChanges();

            //return Ok(videoGame);

            return StatusCode(HttpStatusCode.NotImplemented);
        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing)
            //{
            //    db.Dispose();
            //}
            //base.Dispose(disposing);
        }

        //private bool VideoGameExists(int id)
        //{
        //    return db.VideoGames.Count(e => e.id == id) > 0;
        //}
    }
}