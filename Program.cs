using MerchantGameConsole.GameData;
using MerchantGameConsole.GameData.Controller;
using MerchantGameConsole.GameData.MainMenuContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole
{
    class Program
    {
        public const string PROGRAM_VERSION = "0.1a";
        private readonly ControllerDisplay CDisp;
        private readonly MainMenu MM;

        public Program()
        {
            this.CDisp = new ControllerDisplay();
            MM = new MainMenu();
        }

        static void Main(string[] args)
        {
            Program Program = new Program();
            Program.Launch();
            Program.MainMenu();
            Program.Exit();
        }

        private void Launch()
        {
            CDisp.ProgramLaunch();
        }

        private void MainMenu()
        {
            MM.Load();
        }

        private void Exit()
        {
            CDisp.ProgramExit();
        }
    }
}
