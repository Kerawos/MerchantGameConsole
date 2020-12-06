using MerchantGameConsole.GameData.Map;
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
        public Player Player { get; set; }
        public World World { get; set; }

        private Notification Notification;
        private GameController GameController;

        public Game(Player Player, World World, int GameLevel)
        {
            this.Player = Player;
            this.World = World;
            this.GameLevel = GameLevel;
            Notification = new Notification();
            GameController = new GameController();
        }

        public void Play()
        {
            
            
            

        }

        


    }
}
