using RogueBase.Classes;
using RogueBase.Interfaces;
using RogueBase.Items;
using System;

namespace RogueBase.Classes
{
    public class Player : IActor
    {
        public Storage inventory { get; set; } 

        public string name { get; private set; }
        public int health { get; private set; }
        public int healthMax { get; private set; }

        public Player(string newName)
        {
            name = newName;
            healthMax = 100;
            health = healthMax;
        }

        public void ChangeHealth(int newHealth)
        {
            if (newHealth <= 0)
                health = 0;
            else if (newHealth > healthMax)
                health = healthMax;
            else
                health = newHealth;
        }
    }
}
