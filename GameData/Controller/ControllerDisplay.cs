using MerchantGameConsole.GameData.GameNotification;
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

        public void ProgramLaunch()
        {
            DisplayToUser(N.GameLaunch() + "\r\n" + N.PressAnyKey());
            GetResponseFromUser();
        }

        public void ProgramExit()
        {
            DisplayToUser(N.GameExit() + "\r\n" + N.PressAnyKey());
        }

        public void MainMenu()
        {
            DisplayToUser(N.MainMenuContext() + "\r\n" + N.PressAnyKey());
        }

        public void GameAbout()
        {
            DisplayToUser(N.GameAbout() + "\r\n" + N.PressAnyKey());
        }


    }
}
