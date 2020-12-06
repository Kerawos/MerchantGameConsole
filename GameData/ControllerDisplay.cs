using MerchantGameConsole.GameData.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData
{
    class ControllerDisplay : IControllerIO
    {
        private Notification n;

        public ControllerDisplay()
        {
            this.n = new Notification();
        }
        public void DisplayToUser(string message)
        {
            Console.WriteLine(message);
        }

        public string GetResponseFromUser()
        {
            return Console.ReadLine();
        }

        public void Gamelaunch()
        {
            
        }
    }
}
