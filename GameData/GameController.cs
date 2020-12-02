﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData
{
    class GameController
    {
        public void DisplayToUser(string message)
        {
            Console.WriteLine(message);
        }

        public string GetResponseFromUser()
        {
            return Console.ReadLine();
        }
    }
}
