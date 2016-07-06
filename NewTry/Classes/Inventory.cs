using RogueBase.Interfaces;

namespace RogueBase.Classes
{
    public class Inventory
    {
        private Item[] _items;

        public Inventory(int capacity)
        {
            _items = new Item[capacity];
        }

        public bool Add(Item item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i] != null)
                {
                    continue;
                } // skip items

                _items[i] = item; // assign item to empty slot
                return true; // report success
            }

            return false; // inventory full
        }

        public bool Remove(Item item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if(_items[i] == item) // when match is found
                {
                    _items[i] = null; // remove it
                    return true; // report success
                }
            }

            return false; // no item found
        }

        public Item GetItem(int index)
        {
            try
            {
                return _items[index];
            }
            catch
            {
                return null;
            }
        }

        public int GetCapacity()
        {
            return _items.Length;
        }

        public int GetCount()
        {
            int count = 0;

            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i] != null)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
