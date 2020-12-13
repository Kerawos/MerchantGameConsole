using MerchantGameConsole.GameData.Controller;
using MerchantGameConsole.GameData.GameNotification;
using MerchantGameConsole.GameData.PlayerCharacter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.GameConent
{
    class GameStartup
    {
        private readonly ControllerDisplay CDisp;
        private readonly Notification N;

        public GameStartup()
        {
            CDisp = new ControllerDisplay();
            N = new Notification();
        }


        public Game InitializeGame()
        {
            Game game = new Game();
            CDisp.DisplayToUser(N.WelcomeScreen());
            game.Difficulty = GameDifficultySet();
            game.Player = PlayerCreateNew(game.Difficulty);
            game.World = new Map.World().WorldGenerate(game.Difficulty);
            CDisp.DisplayToUser(N.JourneyBegins(game.Player.Name));
            return new Game();
        }

        

        private Player PlayerCreateNew(int gameDifficulty)
        {
            //Notification.Display("Please specify your character name and press enter to confirm");
            //string PreName = ControllerGame.GetResponseFromUser();
            return new Player();
        }

        private int GameDifficultySet()
        {
            for (int i = 0; i < 3; i++)
            {
                CDisp.DisplayToUser("Please set game level: from 1 to 3. (1=easy)");
                string preLevel = CDisp.GetResponseFromUser();
                try
                {
                    int preLevelInt = Int32.Parse(preLevel);
                    if (preLevelInt <= 3 || preLevelInt > 0)
                    {
                        return preLevelInt;
                    }
                    throw new Exception("PreLevel input out of scope!");
                }
                catch
                {
                    CDisp.DisplayToUser("Game Level cannot be set to: " + preLevel + ", try again.");
                }
            } 
            throw new Exception("Too many attemts during game difficulty set.");
        }
    }
}



