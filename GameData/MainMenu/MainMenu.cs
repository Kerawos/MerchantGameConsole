using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.MainMenu
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
                    
                    case "play":
                        //play
                        break;
                    case "about":
                        break;
                }
            } while (Result != MainMenuType.exit.ToString());
        }
    }
}
