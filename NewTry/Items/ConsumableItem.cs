using RogueBase.Classes;

namespace RogueBase.Interfaces
{
    public abstract class ConsumableItem :
        Item
    {
        public abstract void Consume(Entity entity);
    }
}
