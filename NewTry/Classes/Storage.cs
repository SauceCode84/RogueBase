using RogueBase.Interfaces;

namespace RogueBase.Classes
{
    public class Storage
    {
        //renamed internal field
        private IItem[] _items;

        public Storage(int capacity)
        {
            _items = new IItem[capacity];
        }

        public bool ItemAdd(IItem newItem)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i] as IItem != null) { continue; } // skip items

                _items[i] = newItem; // assign item to empty slot
                return true; // report success
            }
            return false; // inventory full
        }

        public bool ItemRemove(IItem targetItem)
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

        public IItem ItemGetAtIndex(int index)
        {
            IItem atIndex = _items[index];
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
                if (_items[i] is IItem) count++;
            }
            return count;
        }
    }
}
