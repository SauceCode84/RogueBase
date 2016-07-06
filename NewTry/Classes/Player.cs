namespace RogueBase.Classes
{
    public class Player :
        MagicEntity
    {
        public Player(string name) :
            base(name)
        {
            HealthMax = 100;
            Health = HealthMax;

            ManaMax = 25;
            Mana = ManaMax;

            Inventory = new Storage(5);
        }

        public Storage Inventory { get; set; }
    }
}
