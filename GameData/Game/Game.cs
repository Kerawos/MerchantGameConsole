using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.Game
{
    class Game
    {
        public int GameLevel { get; set; }
        public Merchant Player { get; set; }

        private Notification Notification;
        private GameController GameController;

        public Game()
        {
            Notification = new Notification();
            GameController = new GameController();
        }

        public void Play()
        {
            
            
            

        }

        


    }
}
