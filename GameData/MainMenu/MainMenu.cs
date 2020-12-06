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
        private readonly List<string> Options;
        

        public MainMenu()
        {
            this.CDisp = new ControllerDisplay();
            this.Options = new List<string> { "play", "about", "exit" };
            
        }

        public void Load()
        {
            do
            {

            } while (Result == CDisp.GetResponseFromUser())
        }
    }
}
