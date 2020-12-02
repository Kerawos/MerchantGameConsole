using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.Game
{
    class Game
    {
        private Notification Notification { get; set; }
        private int GameLevel { get; set; }
        private Merchant Player { get; set; }
        private GameController GameController;

        public Game()
        {
            Notification = new Notification();
            GameController = new GameController();
        }

        public void GameStart()
        {
            Notification.WelcomeScreenShow();
            GameLevelSet();
            JourneyBeginsShow

        }

        private Merchant CharacterCreate(string Name)
        {
            Merchant PrePlayer = new Merchant(Name);
            PrePlayer.Money = 500 * GameLevel;
            PrePlayer.Items.Add(new Weapon().Create(GameLevel));
            return PrePlayer;
        }

        private void PlayerCreate()
        {
            Notification.Display("Please specify your character name and press enter to confirm");
            string PreName = GameController.GetResponseFromUser();

        }

        private void GameLevelSet()
        {
            bool isSet = false;
            do
            {
                Notification.Display("Please set game level: from 1 to 3. (1=easy)");
                string preLevel = GameController.GetResponseFromUser();
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
