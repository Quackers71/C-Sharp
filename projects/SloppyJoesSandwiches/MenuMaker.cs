using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloppyJoesSandwiches
{
    class MenuMaker
    {
        public Random? Randomizer;

        string[] Meats = { "Roast Beef", "Salami", "Turkey", "Ham", "Pastrami" };
        string[] Condiments = { "yellow mustard", "brown mustard" };
        string[] Breads = { "rye", "white", "wheat", "pumpernickel", "italian bread", "a roll" };

        public string GetMenuItem()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + " with " + randomCondiment + " on " + randomBread;
        }
    }
}
