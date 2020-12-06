using MerchantGameConsole.GameData;
using MerchantGameConsole.GameData.Game;
using MerchantGameConsole.GameData.MainMenu;
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
            Program.Start();
            Program.MainMenu();
            Program.Exit();
        }

        private void Start()
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
