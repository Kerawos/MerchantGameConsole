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



        public GameStartup()
        {
            CDisp = new ControllerDisplay();
        }



        public Game InitializeGame()
        {
            Player player;
            int gameDificulty;
            //Notification.WelcomeScreenShow();
            //GameLevelSet();
            //player creation
            //World generation
            //JourneyBeginsShow
            return new Game();
        }

        private Player PlayerCreate(string Name)
        {
            Player PrePlayer = new Player(Name);
            PrePlayer.Money = 500 * GameLevel;
            PrePlayer.Items.Add(new Weapon().Create(GameLevel));
            return PrePlayer;
        }

        private void PlayerCreate()
        {
            Notification.Display("Please specify your character name and press enter to confirm");
            string PreName = ControllerGame.GetResponseFromUser();

        }

        private void GameDifficultySet()
        {
            bool isSet = false;
            do
            {
                Notification.Display("Please set game level: from 1 to 3. (1=easy)");
                string preLevel = ControllerGame.GetResponseFromUser();
                try
                {
                    int preLevelInt = Int32.Parse(preLevel);
                    if (preLevelInt <= 3 || preLevelInt > 0)
                    {
                        this.GameLevel = preLevelInt;
                        return;
                    }
                    throw new Exception("PreLevel input out of scope!");
                }
                catch
                {
                    Notification.Display("Game Level cannot be set to: " + preLevel + ", try again.");
                }
            } while (!isSet);
        }
    }
}



