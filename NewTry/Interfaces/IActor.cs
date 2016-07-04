using RogueBase.Classes;
using RogueBase.Interfaces;
using RogueBase.Items;
using System;

namespace RogueBase.Interfaces
{
    public interface IActor
    {
        string name { get; set; }
        int health { get; set; }
        int healthMax { get; set; }

        Storage inventory { get; set; }

        void ChangeHealth(int newHealth);
    }
}
