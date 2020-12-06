using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.Game
{
    class Notification
    {

        public string GameLaunch()
        {
            return "Welcome to my game. Version: " + Program.PROGRAM_VERSION;
        }

        public string PressAnyKey()
        {
            return "Press any key to continue.";
        }

        public string GameExit()
        {
            return "Thank you for playing my game.";
        }

        public string GameAbout()
        {
            return "Game during development. Current version is: " + Program.PROGRAM_VERSION;
        }

        public string WelcomeScreen()
        {
            return "Hello traveler, your journey has begin";
        }

        public string JourneyBegins(string playerName)
        {
            return playerName + ", you are the merchant. Your goal is to become rich " +
                "merchant. You have 25 turns to proof that. Try to travel from one city to another. Buy items " +
                "and move to other city and try to sell it with a profit. Good luck!";
        }

        
    }
}
