using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.ItemStuff
{
    public class Armor : Item
    {
        public ArmorType MyType { get; set; }

        public Armor(string name, int price, EItemQuality quality, ArmorType myType) : base(name, price, quality)
        {

        }

    }
}
