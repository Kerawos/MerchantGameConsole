using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.Map
{
    abstract class Town : ITownBehaviour
    {
        private string Name { get; set; }
        private List<Item> ItemsToSell { get; set; }
        private List<Item> ItemsToBuy { get; set; }

    }
}
