using GameIndustry.Model;
using System.Collections.Generic;

namespace GameIndustry
{
    public interface IRepository
    {
        List<Game> GetAllGames();
    }
}
