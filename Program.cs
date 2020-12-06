using MerchantGameConsole.GameData;
using MerchantGameConsole.GameData.Game;
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

        public Program()
        {
            CDisp = new ControllerDisplay();
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
            CDisp.GameLaunch();
        }

        private void MainMenu()
        {
            //exe
        }

        private void Exit()
        {
            //exit
        }
    }
}
