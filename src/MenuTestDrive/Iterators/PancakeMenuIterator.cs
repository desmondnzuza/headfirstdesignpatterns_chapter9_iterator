using System.Collections.Generic;
using MenuTestDrive.MenuItems;

namespace MenuTestDrive.Iterators
{
    class PancakeMenuIterator : IIterator
    {
        private readonly List<IMenuItem> _items;
        private int _position = 0;

        public PancakeMenuIterator(List<IMenuItem> items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            return _position < _items.Count;
        }

        public object Next()
        {
            IMenuItem nextItem = (IMenuItem)_items[_position];
            _position++;

            return nextItem;
        }
    }
}
