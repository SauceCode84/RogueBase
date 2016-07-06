using RogueBase.Classes;

namespace RogueBase.Interfaces
{
    public  interface IConsumableItem :
        IItem
    {
        void Consume(Entity entity);
    }
}
