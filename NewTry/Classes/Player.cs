using System;

using RogueBase.Interfaces;

namespace RogueBase.Classes
{
    public class Player :
        IActor
    {
        public Player(string newName)
        {
            Name = newName;
            HealthMax = 100;
            Health = HealthMax;
            Inventory = new Storage(5);
        }

        public string Name { get; set; }

        public int Health { get; set; }

        public int HealthMax { get; set; }

        public Storage Inventory { get; set; }

        public void ChangeHealth(int change)
        {
            int newHealth = Health;
            newHealth += change;

            if (newHealth <= 0)
            {
                Health = 0;
            }
            else if (newHealth > HealthMax)
            {
                Health = HealthMax;
            }
            else
            {
                Health = newHealth;
            }
        }
    }
}
