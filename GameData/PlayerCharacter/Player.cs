using MerchantGameConsole.GameData.ItemStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.PlayerCharacter
{
    class Player
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public List<Item> Items { get; set; }
        public int Score { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }


      
    }
}

