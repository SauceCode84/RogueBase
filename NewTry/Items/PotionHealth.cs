using RogueBase.Classes;
using RogueBase.Interfaces;

namespace RogueBase.Items
{
    public class PotionHealth :
        IConsumableItem
    {
        public PotionHealth()
        {
            Name = "Health Potion";
            SellValue = 100;
        }

        public string Name { get; set; }

        public int SellValue { get; set; }
        
        public void Equip()
        {
            //
        }

        public void Sell()
        {
            //
        }

        public void Consume(Entity entity)
        {
            entity.Health += 30;
        }
    }
}
