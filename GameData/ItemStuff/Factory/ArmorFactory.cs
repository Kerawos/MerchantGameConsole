using MerchantGameConsole.GameData.ItemStuff.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.ItemStuff
{
    public class ArmorFactory : ItemFactory, IItemFactory
    {
        public Item CreateRandomItem(double modifier)
        {
            int price = Rnd.Next((int)(Item.PRICE_BASE * modifier * 1.5), (int)(Item.PRICE_BASE * 3 * modifier));
            EItemQuality quality = (EItemQuality)Rnd.Next(Enum.GetNames(typeof(EItemQuality)).Length);
            ArmorType type = (ArmorType)Rnd.Next(Enum.GetNames(typeof(ArmorType)).Length);
            return new Armor("Armor", price, quality, type);
        }
    }
}
