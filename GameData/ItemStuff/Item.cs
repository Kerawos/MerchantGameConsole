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
        protected Random Rnd { get; set; }


        public Item()
        {

        }


        public Item(string name, int price, EItemQuality quality)
        {
            this.Name = name;
            this.Price = price;
            this.Quality = quality;
            this.Rnd = new Random();
        }

        
    }
}
   


