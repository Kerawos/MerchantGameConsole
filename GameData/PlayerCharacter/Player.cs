using MerchantGameConsole.GameData.ItemStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.PlayerCharacter
{
    public class Player
    {
        private readonly int Money_Starting = 100;
        public string Name { get; set; }
        public int Money { get; set; }
        public List<Item> Items { get; set; }
        public int Score { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }

        public Player (string name, double gameDifficulty) : this(name)
        {
            this.Money = (int)(Money_Starting * gameDifficulty);
            this.Items.Add(new Weapon().Create(gameDifficulty));
            
        }



    }
}

