using System;
using API.Controllers;
using API.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace UnitTests
{
    [TestClass]
    public class VideoGameControllerTests
    {
        [TestMethod]
        public void get_video_game_by_Id()
        {
            VideoGamesController vgc = new VideoGamesController();

           var videoGame = vgc.GetVideoGame(1);

            Assert.IsNotNull(videoGame);
        }

        [TestMethod]
        public void get_all_video_Games()
        {
            VideoGamesController vgc = new VideoGamesController();

            var videoGames = vgc.GetVideoGames();

            Assert.IsNotNull(videoGames);
        }

        [TestMethod]
        public void update_video_game()
        {
            var newName = "Unit Test";
            VideoGame videoGame;

            VideoGamesController vgc = new VideoGamesController();
            VideoGameRepository repo = new VideoGameRepository();
            videoGame = repo.GetVideoGameByID(1);

            //Update Name
            videoGame.Name = newName;

            //save
            vgc.PostVideoGame(videoGame);

            //requery from DB
            videoGame = repo.GetVideoGameByID(1);
            
            //check
            Assert.AreEqual(videoGame.Name, newName);

        }
    }
}
