using MerchantGameConsole.GameData.Game;
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
            DisplayToUser(N.GameLaunch() + "/n" + N.PressAnyKey());
            GetResponseFromUser();
        }

        public void ProgramExit()
        {
            DisplayToUser(N.GameExit() + "/n" + N.PressAnyKey());
        }

        public void MainMenu()
        {
            DisplayToUser(N.MainMenuContext() + "/n" + N.PressAnyKey());
        }


    }
}
