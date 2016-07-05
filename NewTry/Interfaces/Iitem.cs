namespace RogueBase.Interfaces
{
    public interface IItem
    {
        string Name { get; set; }

        int SellValue { get; set; }

        bool Consumable { get; set; }

        void Equip();

        void Sell();

        void Consume(IActor actor);
    }
}
