using MerchantGameConsole.GameData.Map;
using MerchantGameConsole.GameData.PlayerCharacter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.GameConent
{
    public class Game
    {
        public int Difficulty { get; set; }
        public Player Player { get; set; }
        public World World { get; set; }
        public int Turn { get; set; }

        private GameStartup GameStartup;
        private GameEnd GameEnd;

        public Game()
        {
            this.GameStartup = new GameStartup();
            this.GameEnd = new GameEnd();
        }

        private Game(Player player, World world, int difficulty)
        {
            this.Player = player;
            this.World = world;
            this.Difficulty = difficulty;
            this.Turn = 1;


        }

        public void GameStart()
        {
            //game startup
            //game play
            //game ending
        }

        private void Play()
        {
            //loop + trevel / barter ?
        }

        private void Travel()
        {
            // display map, choose destination, 
        }

        private void Barter()
        {

            // get current town, generate needs, generate shop, switch buy/sell etc
        }

        public int testAdd(int x, int y)
        {
            return x * y * y * x * 5;
        }
    }
}


