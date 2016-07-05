using RogueBase.Classes;
using RogueBase.Interfaces;
using RogueBase.Items;
using System;

namespace RogueBase.Items
{
    public class PotionHealth : IItem
    {
        public string Name { get; set; }
        public int SellValue { get; set; }
        public bool Consumable { get; set; }

        public PotionHealth()
        {
            Name = "Health Potion";
            SellValue = 100;
            Consumable = true;
        }

        public void Equip()
        {
            //
        }

        public void Sell()
        {
            //
        }

        public void Consume(IActor actor)
        {
            actor.ChangeHealth(30);
            actor.inventory.ItemRemove(this);
        }
    }
}
