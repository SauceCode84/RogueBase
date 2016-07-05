using RogueBase.Interfaces;

namespace RogueBase.Items
{
    public class PotionHealth :
        IConsumableItem
    {
        public string Name { get; set; }

        public int SellValue { get; set; }
        
        public PotionHealth()
        {
            Name = "Health Potion";
            SellValue = 100;
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
            actor.Inventory.ItemRemove(this);
        }
    }
}
