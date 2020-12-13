using MerchantGameConsole.GameData.Controller;
using MerchantGameConsole.GameData.GameNotification;
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
        private readonly Notification N;

        public Game()
        {
            this.GameStartup = new GameStartup();
            this.GameEnd = new GameEnd();
            this.CDisp = new ControllerDisplay();
            this.N = new Notification();
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
            Play();
            //game ending
        }

        private void Play()
        {
            string result;
            do
            {
                CDisp.GamePlay(Player.location.Name);
                result = CDisp.GetResponseFromUser();
                switch (result)
                {
                    case "travel":
                        new Game().GameStart();
                        break;
                    case "barter":
                        CDisp.GameAbout();
                        break;
                }
            } while (result != "exit");
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


