using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MerchantGameConsole.GameData;


namespace MerchantGameConsole.GameData.ItemStuff
{
    class Weapon : Item
    {

        private Weapon(string Name, int Price, EItemQuality Quality) : base(Name, Price, Quality)
        {

        }

        public Weapon()
        {

        }


        public Weapon Create()
        {
            return new Weapon("Weapon", 100, EItemQuality.normal);
        }


        public Weapon Create(int modifier)
        {
            return new Weapon("Weapon", rnd.Next(100 * modifier, 200 * modifier), (EItemQuality)rnd.Next(Enum.GetNames(typeof(EItemQuality)).Length));
        }
    }
    
}

