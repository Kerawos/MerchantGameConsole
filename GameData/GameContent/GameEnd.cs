using MerchantGameConsole.GameData.Controller;
using MerchantGameConsole.GameData.PlayerCharacter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.GameConent
{
    class GameEnd
    {
        private readonly ControllerDisplay CDisp;

        public GameEnd()
        {
            this.CDisp = new ControllerDisplay();
        }


        public void GameEnding(Player player)
        {
            if (player.GetScore() < 0)
            {
                CDisp.GameEndBad(player.GetScore());
            }
            else if (player.GetScore() < 1000)
            {
                CDisp.GameEndNormal(player.GetScore());
            }
            else
            {
                CDisp.GameEndGood(player.GetScore());
            }
        }
                
    }
}


