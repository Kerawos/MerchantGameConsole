using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.Map
{
    abstract class Town : ITownBehaviour
    {
        public string Name { get; set; }
        public List<Item> Items { get; set; }

        public List<Item> GenerateItemsToSell()
        {
            throw new NotImplementedException();
        }

        public List<Item> GenerateNeeds()
        {
            throw new NotImplementedException();
        }
    }
}
