using RogueBase.Classes;
using RogueBase.Interfaces;
using RogueBase.Items;
using System;

namespace RogueBase.Classes
{
    public class Storage
    {
        //renamed internal field
        private Iitem[] _inventory;

        public Storage(int capacity)
        {
            _inventory = new Iitem[capacity];
        }

        public bool ItemAdd(Iitem newItem)
        {
            for (int i = 0; i < _inventory.Length; i++)
            {
                if (_inventory[i] as Iitem != null) { continue; } // skip items

                _inventory[i] = newItem; // assign item to empty slot
                return true; // report success
            }
            return false; // inventory full
        }

        public bool ItemRemove(Iitem targetItem)
        {
            for (int i = 0; i < _inventory.Length; i++)
            {
                if(_inventory[i] == targetItem) // when match is found
                {
                    _inventory[i] = null; // remove it
                    return true; // report success
                }
            }
            return false; // no item found
        }

        public Iitem ItemGetAtIndex(int index)
        {
            Iitem atIndex = _inventory[index];
            return atIndex;
        }

        public int ItemGetCapacity()
        {
            return _inventory.Length;
        }


        public int ItemGetCount()
        {
            int count = 0;
            for (int i = 0; i < _inventory.Length; i++)
            {
                if (_inventory[i] is Iitem) count++;
            }
            return count;
        }
    }
}
