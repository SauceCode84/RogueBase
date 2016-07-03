using RogueBase.Classes;
using RogueBase.Interfaces;
using RogueBase.Items;
using System;

namespace RogueBase.Items
{
    public class PotionHealth : Iitem
    {
        public string name { get; set; }
        public int sellValue { get; set; }
        public bool consumable { get; set; }

        PotionHealth()
        {
            name = "Health Potion";
            sellValue = 100;
            consumable = true;
        }

        public void Equip()
        {
            //
        }

        public void Sell()
        {
            //
        }

        public void Consume()
        {
            // unable to access  public Player hero
        }
    }
}
