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

        private Weapon(string name, int price, EItemQuality quality) : base(name, price, quality)
        {

        }

        public Weapon()
        {

        }


        public Weapon Create()
        {
            return new Weapon("Weapon", 100, EItemQuality.normal);
        }


        public Weapon Create(double modifier)
        {
            return new Weapon("Weapon", Rnd.Next(
                (int)(100 * modifier), (int)(200 * modifier)), 
                    (EItemQuality)Rnd.Next(Enum.GetNames(typeof(EItemQuality)).Length));
        }
    }
    
}

