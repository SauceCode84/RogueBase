namespace RogueBase.Interfaces
{
    public interface IItem
    {
        string Name { get; set; }

        int SellValue { get; set; }

        void Equip();

        void Sell();
    }
}
