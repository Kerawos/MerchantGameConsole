using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData
{
    interface IControllerIO
    {
        void DisplayToUser(string message);
        string GetResponseFromUser();
    }
}
