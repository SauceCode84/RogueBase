using RogueBase.Classes;
using RogueBase.Interfaces;

namespace RogueBase.Items
{
    public class PotionHealth :
        ConsumableItem
    {
        public PotionHealth()
        {
            Name = "Health Potion";
            SellValue = 100;
        }

        public override void Equip(Entity entity)
        {
            //
        }

        public override void Sell()
        {
            //
        }

        public override void Consume(Entity entity)
        {
            entity.Health += 30;
        }        
    }
}
