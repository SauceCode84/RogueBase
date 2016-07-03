using RogueBase.Classes;
using RogueBase.Interfaces;
using RogueBase.Items;
using System;

namespace RogueBase
{
    class Program
    {
        public Player hero = new Player("MainCharacter");

        static void Main(string[] args)
        {
            //Console.WriteLine($"{hero.name}'s HP: {hero.health}");
            
            //Console.WriteLine($"inventory size: ");

            Console.ReadKey();
        }
    }
}
