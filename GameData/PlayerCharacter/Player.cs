using MerchantGameConsole.GameData.ItemStuff;
using MerchantGameConsole.GameData.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MerchantGameConsole.GameData.PlayerCharacter
{
    public class Player
    {
        private readonly int MoneyStarting = 100;
        public string Name { get; set; }
        public int Money { get; set; }
        public List<Item> Items { get; set; }
        private int Score { get; set; }
        public Town location { get; set; }

        public Player()
        {

        }

        public Player(string name)
        {
            this.Name = name;
        }

        public Player (string name, double gameDifficulty) : this(name)
        {
            this.Money = (int)(MoneyStarting * gameDifficulty);
            this.Items = new List<Item>() {
                new WeaponFactory().CreateRandomItem(gameDifficulty),
                new WeaponFactory().CreateRandomItem(gameDifficulty),
                new ArmorFactory().CreateRandomItem(gameDifficulty)};
        }


        public int GetScore()
        {
            ScoreUpdate();
            return Score;
        }

        private void ScoreUpdate()
        {
            this.Score = Money + Items.Count() * MoneyStarting / 2;
        }

        public bool IsCorrectname(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }

    }
}

