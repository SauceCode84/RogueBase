using RogueBase.Interfaces;

namespace RogueBase.Classes
{
    public class Storage
    {
        //renamed internal field
        private Item[] _items;

        public Storage(int capacity)
        {
            _items = new Item[capacity];
        }

        public bool ItemAdd(Item newItem)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i] as Item != null) { continue; } // skip items

                _items[i] = newItem; // assign item to empty slot
                return true; // report success
            }
            return false; // inventory full
        }

        public bool ItemRemove(Item targetItem)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if(_items[i] == targetItem) // when match is found
                {
                    _items[i] = null; // remove it
                    return true; // report success
                }
            }
            return false; // no item found
        }

        public Item ItemGetAtIndex(int index)
        {
            Item atIndex = _items[index];
            return atIndex;
        }

        public int ItemGetCapacity()
        {
            return _items.Length;
        }

        public int ItemGetCount()
        {
            int count = 0;
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i] is Item) count++;
            }
            return count;
        }
    }
}
