using MerchantGameConsole.GameData.Controller;
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
        private readonly ControllerDisplay CDisp;

        public Game()
        {
            this.GameStartup = new GameStartup();
            this.GameEnd = new GameEnd();
            this.CDisp = new ControllerDisplay();
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
            Game game = new Game();
            game = GameStartup.InitializeGame();
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

    }
}


