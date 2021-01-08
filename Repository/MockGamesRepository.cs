using GameIndustry.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameIndustry.Repository
{
    public class MockGamesRepository : IRepository
    {
        List<Game> _games;

        public MockGamesRepository()
        {
            _games = new List<Game>()
            {
                new Game()
                {
                    Name = "Farming Simulator 2019",
                    Genre = "Simulator",
                    ReleaseDate = new DateTime(2018, 11, 19)
                },

                new Game()
                {
                    Name = "The Witcher 3",
                    Genre = "Action/RPG",
                    ReleaseDate = new DateTime(2015, 05, 18)
                },

                new Game()
                {
                    Name = "Destroy All Humans!",
                    Genre = "Action-Adventure",
                    ReleaseDate = new DateTime(2020, 07, 28)
                }
            };
        }

        public List<Game> GetAllGames()
        {
            return _games;
        }
    }
}
