using MerchantGameConsole.GameData.GameNotification;
using MerchantGameConsole.GameData.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.Controller
{
    class ControllerDisplay : IControllerIO
    {
        private readonly Notification N;

        public ControllerDisplay()
        {
            this.N = new Notification();
        }
        public void DisplayToUser(string message)
        {
            Console.WriteLine(message);
        }

        public string GetResponseFromUser()
        {
            return Console.ReadLine();
        }

        public void ViewClear()
        {
            Console.Clear();
        }

        public void ProgramLaunch()
        {
            ViewClear();
            DisplayToUser(N.GameLaunch() + "\r\n" + N.PressAnyKey());
            GetResponseFromUser();
        }

        public void ProgramExit()
        {
            ViewClear();
            DisplayToUser(N.GameExit() + "\r\n" + N.PressAnyKey());
            GetResponseFromUser();
        }

        public void MainMenu()
        {
            ViewClear();
            DisplayToUser(N.MainMenuContext() + "\r\n" + N.PressAnyKey());
        }

        public void GameAbout()
        {
            ViewClear();
            DisplayToUser(N.GameAbout() + "\r\n" + N.PressAnyKey());
            GetResponseFromUser();
        }

        public void GamePlay(string location)
        {
            ViewClear();
            DisplayToUser(N.GamePlayOption(location));
        }

        public void NextTurnInfo(int turn, int score)
        {
            ViewClear();
            DisplayToUser(N.NextTurnInfo(turn, score));
        }


    }
}
