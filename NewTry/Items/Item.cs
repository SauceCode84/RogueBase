using RogueBase.Classes;

namespace RogueBase.Interfaces
{
    public abstract class Item
    {
        public string Name { get; set; }

        public int SellValue { get; set; }

        public abstract void Equip(Entity entity);

        public abstract void Sell();
    }
}
