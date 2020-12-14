using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.ItemStuff.Factory
{
    public abstract class ItemFactory
    {
        protected Random Rnd { get; set; }

        public ItemFactory()
        {
            this.Rnd = new Random();
        }
    }
}
