using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.Game
{
    class Notification
    {
        private GameController GameController;

        public Notification()
        {
            GameController = new GameController();
        }

        public void Display(string message)
        {
            GameController.DisplayToUser(message);
        }
        public void WelcomeScreenShow()
        {
            GameController.DisplayToUser("Hello traveler, your journey has begin");
        }

        public void JourneyBeginsShow(string playerName)
        {
            GameController.DisplayToUser(playerName + ", you are the merchant. Your goal is to become rich " +
                "merchant. You have 25 turns to proof that. Try to travel from one city to another. Buy items " +
                "and move to other city and try to sell it with a profit. Good luck!");
        }

        
    }
}
