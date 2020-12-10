using Microsoft.VisualStudio.TestTools.UnitTesting;
using MerchantGameConsole.GameData.ItemStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.ItemStuff.Tests
{
    [TestClass()]
    public class WeaponTests
    {
        [TestMethod()]
        public void CreateTest()
        {
            Weapon weaponPoor = new Weapon().Create(0.5);
            Weapon weaponNormal = new Weapon().Create();
            Weapon weaponMight = new Weapon().Create(1.4);
            Assert.IsTrue(weaponNormal.Price>weaponPoor.Price, "Ok");
            Assert.IsTrue(weaponMight.Quality > weaponNormal.Quality, "Ok");
            Assert.IsFalse(weaponPoor.Price > weaponMight.Price, "Not Ok");
            
        }

        public void Test2()
        {

        }
    }
}