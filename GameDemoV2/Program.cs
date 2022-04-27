using GameDemoV2.Concrete;
using System;

namespace GameDemoV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game() { GameID = 1, GameName = "Game1", UnitPrice = 1234 };
            GameManager gamerManager = new GameManager();

            gamerManager.Add(game);

        }
    }
}
