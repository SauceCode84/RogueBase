using RogueBase.Classes;

namespace RogueBase.Interfaces
{
    public interface IActor
    {
        string Name { get; set; }
        int Health { get; set; }
        int HealthMax { get; set; }

        Storage Inventory { get; set; }

        void ChangeHealth(int newHealth);
    }
}
