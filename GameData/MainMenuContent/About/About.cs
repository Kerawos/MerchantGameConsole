using MerchantGameConsole.GameData.Controller;
using MerchantGameConsole.GameData.GameNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.MainMenuContent
{
    public class About
    {
        private readonly ControllerDisplay CDisp;
        private readonly Notification N;

        public About()
        {
            this.CDisp = new ControllerDisplay();
            this.N = new Notification();
        }

        public void ShowAbout()
        {
            CDisp.DisplayToUser(N.GameAbout());
        }

        private string ExtractsGet()
        {
            return null;
        }

        private string AuthorsGet()
        {
            return null;
        }
    }
}


