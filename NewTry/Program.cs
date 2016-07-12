using RogueBase.Classes;

using RLNET;

namespace RogueBase
{
    class Program
    {
        public static Player hero { get; private set; } // only one player

        static void Main(string[] args)
        {
            /*Player hero = new Player("MainCharacter");

            Console.WriteLine($"{hero.Name}'s HP: {hero.Health}"); // 100
            Console.WriteLine($"Items held: {hero.Inventory.GetCount()}"); // 0
            Console.WriteLine();

            hero.Health -= 50;

            Console.WriteLine($"{hero.Name}'s HP: {hero.Health}"); // 50
            Console.WriteLine();
            
            hero.Inventory.Add(new PotionHealth()); // add new potion to inventory

            Console.WriteLine($"Items held: {hero.Inventory.GetCount()}"); // 1
            Console.WriteLine();

            // call directly from player inventory index
            ConsumableItem item = hero.Inventory.GetItem(0) as ConsumableItem;

            item.Consume(hero);
            hero.Inventory.Remove(item);

            Console.WriteLine($"{hero.Name}'s HP: {hero.Health}"); // 80
            Console.WriteLine($"Items held: {hero.Inventory.GetCount()}"); // 0
            Console.WriteLine();*/

            RLRootConsole rootConsole = new RLRootConsole(@"Resources\ascii_8x8.png", 60, 40, 8, 8);
            GameEngine engine = new GameEngine(rootConsole);
                        
            rootConsole.Run();            
        }
    }
}
