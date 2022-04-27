using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemoV2.Concrete
{
    internal class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " Game Added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " Game Deleted");
        }

        public void Sell(Game game)
        {
            Console.WriteLine(game.GameName + " Game Sold");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " Game Updated");
        }
    }
}
