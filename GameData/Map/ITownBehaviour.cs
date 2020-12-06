using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.Map
{
    interface ITownBehaviour
    {
        List<Item> GenerateItemsToSell();
        List<Item> GenerateNeeds();
    }
}
