using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.Map
{
    public class World
    {
        public List<Town> Towns { get; set; }

        private readonly List<string> TownNames = new List<string>()
        {
            "Woodcity", "Stonecamp", "Milling", "Tumbering", "Arena", "Foolfort"
        };


        public World(int gameDifficulty)
        {
            
            if (gameDifficulty > 3 || gameDifficulty < 1)
            {
                throw new Exception("Game difficulty error. Game diffuculty is set to: " + gameDifficulty +
                    ", this is beyond the acceptance level 1-3.");
            }
            int worldSize = 3 + gameDifficulty;
            this.Towns = new List<Town>();
            for (int i = 0; i < worldSize; i++)
            {
                this.Towns.Add(new Town(TownNames[0], gameDifficulty));
            }
        }


    }
}
