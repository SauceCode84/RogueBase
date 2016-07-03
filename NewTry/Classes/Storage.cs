using RogueBase.Classes;
using RogueBase.Interfaces;
using RogueBase.Items;
using System;

namespace RogueBase.Classes
{
    public class Storage
    {
        private Iitem[] inventory;

        public Storage(int capacity)
        {
            inventory = new Iitem[capacity];
        }

        public bool ItemAdd(Iitem newItem)
        {
            for (int i = 0; i < inventory.Length; i++) // check each slot
            {
                if (inventory[i] as Iitem != null) { continue; } // skip items

                inventory[i] = newItem; // assign item to empty slot
                return true; // report success
            }
            return false; // inventory full
        }

        public bool ItemRemove(Iitem targetItem)
        {
            for (int i = 0; i < inventory.Length; i++) // check each slot
            {
                if(inventory[i] == targetItem) // when match is found
                {
                    inventory[i] = null; // remove it
                    return true; // report success
                }
            }
            return false; // no item found
        }

        // return max amount of items that can be held
        public int ItemGetCapacity()
        {
            return inventory.Length;
        }

        // return the amount of  items currently held
        public int ItemGetCount()
        {
            int count = 0;
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] is Iitem) count++;
            }
            return count;
        }
    }
}
