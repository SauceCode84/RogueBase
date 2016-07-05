using RogueBase.Classes;
using RogueBase.Interfaces;
using RogueBase.Items;
using System;

namespace RogueBase.Interfaces
{
    public interface Iitem
    {
        string name { get; set; }
        int sellValue { get; set; }
        bool consumable { get; set; }

        void Equip();
        void Sell();
        void Consume(IActor actor);
    }
}
