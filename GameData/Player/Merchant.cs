using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.Game
{
    class Merchant
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public List<Item> Items { get; set; }

    public Merchant(string Name)
        {
            this.Name = Name;
        }
      
    }
}

