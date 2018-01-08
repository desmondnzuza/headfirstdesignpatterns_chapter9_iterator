using MenuTestDrive.MenuItems;

namespace MenuTestDrive.Iterators
{
    class DinerMenuIterator : IIterator
    {
        private readonly IMenuItem[] _items;
        private int _position = 0;

        public DinerMenuIterator(IMenuItem[] items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            if (_position >= _items.Length || _items[_position] == null)
            {
                return false;
            }

            return true;
        }

        public object Next()
        {
            IMenuItem nextItem = (IMenuItem)_items[_position];
            _position++;

            return nextItem;
        }
    }
}
