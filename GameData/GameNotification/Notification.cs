using MerchantGameConsole;
using MerchantGameConsole.GameData.GameConent;
using MerchantGameConsole.GameData.MainMenuContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.GameNotification
{
    public class Notification
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
                "merchant. You have " + Game.TURN_LIMIT + " turns to proof that. Try to travel from one city to another. Buy items " +
                "and move to other city and try to sell it with a profit. Good luck!";
        }

        public string MainMenuContext()
        {
            List<string> mainMenuTypes = Enum.GetNames(typeof(MainMenuType)).ToList();
            return "MAIN MENU: \r\n\r\n" +
                    "Comands: \r\n\r\n" + String.Join("\r\n", mainMenuTypes.ToArray()) + "\r\n\r\n" +
                     "Enter a command and press enter to confirm.";
           
        }

        public string GamePlayOption(string location)
        {
            return "You are in : " + location + " \r\n " +
                "What you want to do? \r\n\r\n" +
                "travel \r\n " +
                "barter \r\n" +
                "exit \r\n" +
                "Enter a command and press enter to confirm.";
        }

        public string NextTurnInfo(int turn, int score)
        {
            return "Next turn. \r\n\r\n " +
                "Current turn: " + turn + "\r\n\r\n" +
                "Current score: " + score;
        }

        public string TravelWhere(List<string> locations)
        {
            return "Choose location you are want to go:\r\n\r\n" +
                 String.Join("\r\n", locations);
        }

        public string TravelCompelte(string currentLocation)
        {
            return "After long trip, you are able to reach: " + currentLocation + ", good job!";
        }

        public string GameEndScoreBad(int score)
        {
            return "";
        }

        public string GameEndScoreNormal(int score)
        {
            return "";
        }

        public string GameEndScoreGood(int score)
        {
            return "";
        }



    }
}


