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
            CDisp.DisplayToUser(N.WelcomeScreen());
            int gameDificulty = GameDifficultySet();
            //Player player;
            //GameLevelSet();
            //player creation
            //World generation
            //JourneyBeginsShow
            return new Game();
        }

        

        private void PlayerCreateNew()
        {
            //Notification.Display("Please specify your character name and press enter to confirm");
            //string PreName = ControllerGame.GetResponseFromUser();

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



