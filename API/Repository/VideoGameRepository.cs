using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace API.Repository
{
    public class VideoGameRepository
    {
        private APIContext db = new APIContext();

        public IQueryable<VideoGame> GetVideoGames()
        {
            var data = from v in db.VideoGames select v;

            return data;
        }

        public VideoGame GetVideoGameByID(int id)
        {
            var data = (from v in db.VideoGames
                        where v.id == id
                        select v).FirstOrDefault();

            return data;
        }

        public void addVideoGame(VideoGame videogame)
        {
            //TODO data validation on the server, never trust the client to do it. 
            db.VideoGames.Add(videogame);
            db.SaveChanges();
        }

        public void deleteVideoGame(int id)
        {
            var videoGame = GetVideoGameByID(id);

            db.VideoGames.Remove(videoGame);
            db.SaveChanges();
        }

        public void updateVideoGame(VideoGame videoGame)
        {
            var existingVideoGame = db.VideoGames.Where(v => v.id == videoGame.id).FirstOrDefault();              

            if (existingVideoGame != null)
            {
                existingVideoGame.Name = videoGame.Name;
                existingVideoGame.Developer = videoGame.Developer;
                existingVideoGame.ESRBRating = videoGame.ESRBRating;
                existingVideoGame.Platform = videoGame.Platform;
                existingVideoGame.ReleaseDate = videoGame.ReleaseDate;

                db.SaveChanges();
            }      
        }
    }
}