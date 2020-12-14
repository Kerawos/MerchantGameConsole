using MerchantGameConsole.GameData.ItemStuff.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.ItemStuff
{
    public class WeaponFactory : ItemFactory, IItemFactory
    {
        public Item CreateRandomItem(double modifier)
        {
            int price = Rnd.Next((int)(Item.PRICE_BASE * modifier), (int)(Item.PRICE_BASE * 2 * modifier));
            EItemQuality quality = (EItemQuality)Rnd.Next(Enum.GetNames(typeof(EItemQuality)).Length);
            WeaponType type = (WeaponType)Rnd.Next(Enum.GetNames(typeof(WeaponType)).Length);
            return new Weapon("Weapon", price, quality, type);
        }
    }
}
