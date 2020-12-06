using MerchantGameConsole.GameData.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Game NewGame = new GameStartup().InitializeGame();
            NewGame.Play();
        }
    }
}
