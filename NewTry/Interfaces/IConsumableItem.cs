namespace RogueBase.Interfaces
{
    public  interface IConsumableItem :
        IItem
    {
        void Consume(IActor actor);
    }
}
