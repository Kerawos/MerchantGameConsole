using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MerchantGameConsole.GameData.Game;

namespace MerchantGameConsole.GameData.MainMenuContent
{
    public class MainMenu
    {
        private string Result { get; set; }

        private readonly ControllerDisplay CDisp;

        public MainMenu()
        {
            this.CDisp = new ControllerDisplay();
        }

        public void Load()
        {
            do
            {
                CDisp.MainMenu();
                Result = CDisp.GetResponseFromUser();
                switch (Result)
                {
                    case "play": //MainMenuType.play.ToString():
                        GameEnd ge = new GameEnd();
                        Game g = new Game();
                        break;
                    case "about":
                        break;
                }
            } while (Result != MainMenuType.exit.ToString());
        }
    }
}


