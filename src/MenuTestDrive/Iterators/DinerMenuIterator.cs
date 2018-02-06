using System.Collections;
using System.Collections.Generic;
using MenuTestDrive.MenuItems;

namespace MenuTestDrive.Iterators
{
    class DinerMenuIterator : IEnumerator<IMenuItem>
    {
        private readonly IMenuItem[] _items;
        private int _position = 0;

        public DinerMenuIterator(IMenuItem[] items)
        {
            _items = items;
        }

        public bool MoveNext()
        {
            if (_position >= _items.Length || _items[_position] == null)
            {
                return false;
            }

            return true;
        }

        public void Reset()
        {
            _position = 0;
        }

        public IMenuItem Current => GetCurrent();

        object IEnumerator.Current
        {
            get => GetCurrent();
        }

        public void Dispose()
        {
            _position = 0;
        }

        private IMenuItem GetCurrent()
        {
            IMenuItem nextItem = _items[_position];
            _position++;

            return nextItem;
        }
    }
}
