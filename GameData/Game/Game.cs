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
        public int Difficulty { get; set; }
        public Player Player { get; set; }
        public World World { get; set; }
        public int Turn { get; set; }

        private Notification Notification;
        private GameController GameController;

        public Game(Player Player, World World, int Difficulty)
        {
            this.Player = Player;
            this.World = World;
            this.Difficulty = Difficulty;
            this.Turn = 1;
            Notification = new Notification();
            GameController = new GameController();
        }

        public void Play()
        {
            
            
            

        }

        


    }
}
