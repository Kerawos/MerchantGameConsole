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
            Program.Start()
            Program.Execute();
            Program.Exit();
        }

        private void Start()
        {
            CDisp.GameLaunch();
        }

        private void Execute()
        {
            //exe
        }

        private void Exit()
        {
            //exit
        }
    }
}
