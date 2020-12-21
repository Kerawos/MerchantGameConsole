using MerchantGameConsole.GameData.Controller;
using MerchantGameConsole.GameData.GameNotification;
using MerchantGameConsole.GameData.PlayerCharacter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            CDisp.ViewClear();
            CDisp.DisplayToUser(N.WelcomeScreen());
            game.Difficulty = GameDifficultySet();
            game.Player = PlayerCreateNew(game.Difficulty);
            game.World = new Map.World(game.Difficulty);
            game.Player.location = game.World.Towns[0];
            CDisp.DisplayToUser(N.JourneyBegins(game.Player.Name));
            return game;
        }


        private int GameDifficultySet()
        {
            for (int i = 0; i < 5; i++)
            {
                CDisp.DisplayToUser("Please set game level: from 1 to 3. (1=easy)");
                string preLevel = CDisp.GetResponseFromUser();

                try
                {
                    int preLevelInt = Int32.Parse(preLevel);
                    if (preLevelInt <= 3 || preLevelInt > 0)
                        return preLevelInt;
                    throw new Exception("PreLevel input out of scope!");
                }
                catch
                {
                    CDisp.DisplayToUser("Game Level cannot be set to: " + preLevel + ", try again.");
                }
            } 
            throw new Exception("Too many attemts during game difficulty set.");
        }


        private Player PlayerCreateNew(int gameDifficulty)
        {
            Player prePlayer = new Player();
            for (int i = 0; i < 5; i++)
            {
                CDisp.DisplayToUser("What is your name?");
                string preName = CDisp.GetResponseFromUser();
                if (preName.Length < 3)
                    CDisp.DisplayToUser("Your name: " + preName + " cannot be shorther thank 3 letters. Try again.");
                else if (!prePlayer.IsCorrectname(preName))
                    CDisp.DisplayToUser("Your name: " + preName + " is incorrected. Name can contain only letters. " +
                        "Minimum 3 characters. Try again.");
                else
                    return new Player(preName, gameDifficulty);
            }
            throw new Exception("Too many attemts during player creation");
        }
    }
}



