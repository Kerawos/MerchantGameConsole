using MerchantGameConsole.GameData.Controller;
using MerchantGameConsole.GameData.Map;
using MerchantGameConsole.GameData.PlayerCharacter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.GameContent
{
    class Travel
    {
        private readonly ControllerDisplay CDisp;

        public Travel()
        {
            this.CDisp = new ControllerDisplay();
        }


        public void TravelTo(Player player, World world)
        {
            CDisp.TravelTo(AvailableLocationsGet(player.location, world.Towns));
        }

        public void TravelComplete(Player player)
        {
            CDisp.TravelComplete(player.location.Name);
        }

        private List<string> AvailableLocationsGet(Town currentTown, List<Town> towns)
        {
            List<Town> availableTowns = new List<Town>(towns);
            availableTowns.Remove(currentTown);
            return availableTowns.Select(x => x.ToString()).ToList();
        }
    }

}