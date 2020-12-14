using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MerchantGameConsole.GameData;


namespace MerchantGameConsole.GameData.ItemStuff
{
    public class Weapon : Item
    {
        public WeaponType MyType { get; set; }

        public Weapon(string name, int price, EItemQuality quality, WeaponType myType) : base(name, price, quality)
        {

        }

      
 
    }
    
}

