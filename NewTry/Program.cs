using RogueBase.Classes;
using RogueBase.Interfaces;
using RogueBase.Items;
using System;

namespace RogueBase
{
    class Program
    {
        public static Player hero { get; private set; } // only one player

        static void Main(string[] args)
        {
            Player hero = new Player("MainCharacter");

            Console.WriteLine($"{hero.Name}'s HP: {hero.Health}"); // 100
            Console.WriteLine($"Items held: {hero.Inventory.ItemGetCount()}"); // 0
            Console.WriteLine();

            hero.Health -= 50;

            Console.WriteLine($"{hero.Name}'s HP: {hero.Health}"); // 50
            Console.WriteLine();
            
            hero.Inventory.ItemAdd(new PotionHealth()); // add new potion to inventory

            Console.WriteLine($"Items held: {hero.Inventory.ItemGetCount()}"); // 1
            Console.WriteLine();

            // call directly from player inventory index
            ConsumableItem item = hero.Inventory.ItemGetAtIndex(0) as ConsumableItem;

            item.Consume(hero);
            hero.Inventory.ItemRemove(item);

            Console.WriteLine($"{hero.Name}'s HP: {hero.Health}"); // 80
            Console.WriteLine($"Items held: {hero.Inventory.ItemGetCount()}"); // 0
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
