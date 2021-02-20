using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameIndustry.Helpers
{
    public class GameHandler
    {
        // Создаём свойство элементов игры
        public RSPOptions Choose { get; set; }
        // Создаём свойство хранения элемента для победы
        public RSPOptions WinCondition { get; set; }
        // Создаём свойство хранения элемента для поражения
        public RSPOptions LooseCondition { get; set; }
        // Создаём свойство для хранения изображения
        public string Image { get; set; }

        // Создаём метод обработки результата игры
        public GameState GameResult(GameHandler opponent)
        {
            if (Choose == opponent.Choose)
                return GameState.Draw;
            if (LooseCondition == opponent.Choose)
                return GameState.Loss;
            return GameState.Victory;
        }
    }
    // Next step 6
}
