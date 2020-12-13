using MerchantGameConsole.GameData.ItemStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.Map
{
    public class Town : ITownBehaviour
    {
        public string Name { get; set; }
        public int CityDifficulty { get; set; }
        private List<Item> Items { get; set; }

        public Town(string name, int difficulty)
        {
            this.Name = name;
            this.CityDifficulty = difficulty;
        }


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
