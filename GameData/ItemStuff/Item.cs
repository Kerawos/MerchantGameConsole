using MerchantGameConsole.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.ItemStuff
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public EItemQuality Quality { get; set; }
        protected Random rnd { get; set; }

        public Item(string Name, int Price, EItemQuality Quality)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quality = Quality;
            rnd = new Random();
        }

        public Item()
        {

        }
    }
}
   


