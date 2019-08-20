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
        private APIContext db = new APIContext();

        // GET: api/VideoGames
        public IQueryable<VideoGame> GetVideoGames()
        {
            return repo.GetVideoGames();
        }

        // GET: api/VideoGames/5
        [ResponseType(typeof(VideoGame))]
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
        public IHttpActionResult PutVideoGame(int id, VideoGame videoGame)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != videoGame.id)
            {
                return BadRequest();
            }

            repo.updateVideoGame(videoGame);
            //try
            //{
            //    db.SaveChanges();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!VideoGameExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            return StatusCode(HttpStatusCode.OK);
        }

        // POST: api/VideoGames
        [ResponseType(typeof(VideoGame))]
        public IHttpActionResult PostVideoGame(VideoGame videoGame)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            repo.addVideoGame(videoGame);

            return CreatedAtRoute("DefaultApi", new { id = videoGame.id }, videoGame);
        }

        // DELETE: api/VideoGames/5
        [ResponseType(typeof(VideoGame))]
        public IHttpActionResult DeleteVideoGame(int id)
        {
            VideoGame videoGame = db.VideoGames.Find(id);
            if (videoGame == null)
            {
                return NotFound();
            }

            db.VideoGames.Remove(videoGame);
            db.SaveChanges();

            return Ok(videoGame);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VideoGameExists(int id)
        {
            return db.VideoGames.Count(e => e.id == id) > 0;
        }
    }
}