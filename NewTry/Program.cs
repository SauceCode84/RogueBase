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

            Console.WriteLine($"{hero.name}'s HP: {hero.health}"); // 100

            hero.ChangeHealth(-50);

            Console.WriteLine($"{hero.name}'s HP: {hero.health}"); // 50

            PotionHealth testPotion = new PotionHealth();
            //hero.inventory.ItemAdd(testPotion); // ??
            testPotion.Consume(hero);

            Console.WriteLine($"{hero.name}'s HP: {hero.health}"); // 80

            //Console.WriteLine($"inventory size: ");

            Console.ReadKey();
        }
    }
}
