using RogueBase.Classes;
using RogueBase.Interfaces;
using RogueBase.Items;
using System;

namespace RogueBase.Classes
{
    public class Player : IActor
    {
        public Storage inventory { get; set; } 

        public string name { get; set; }
        public int health { get; set; }
        public int healthMax { get; set; }

        public Player(string newName)
        {
            name = newName;
            healthMax = 100;
            health = healthMax;
            inventory = new Storage(5);
        }

        public void ChangeHealth(int change)
        {
            int newHealth = health;
            newHealth += change;

            if (newHealth <= 0)
                health = 0;
            else if (newHealth > healthMax)
                health = healthMax;
            else
                health = newHealth;
        }
    }
}
