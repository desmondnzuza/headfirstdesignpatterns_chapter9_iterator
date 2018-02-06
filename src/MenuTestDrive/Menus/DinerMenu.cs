using System;
using System.Collections.Generic;
using MenuTestDrive.Iterators;
using MenuTestDrive.MenuItems;

namespace MenuTestDrive.Menus
{
    class DinerMenu
    {
        private const int MAX_ITEMS = 6;
        private int _numberOfItems = 0;
        private IMenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new IMenuItem[MAX_ITEMS];

            AddMenueItem(new VegiratianBlt());
            AddMenueItem(new Blt());
            AddMenueItem(new SoupOfTheDay());
            AddMenueItem(new Hotdog());
            AddMenueItem(new SteamedVeggiesAndBrownRice());
            AddMenueItem(new Pasta());
        }

        public void AddMenueItem(string name, string description, bool vegitarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegitarian, price);
            if (_numberOfItems >= MAX_ITEMS)
            {
                Console.Error.WriteLine("Sorry, menu is full!! Can't add to menu");
            }
            else
            {
                _menuItems[_numberOfItems] = menuItem;
                _numberOfItems++;
            }
        }

        public void AddMenueItem(IMenuItem newItem)
        {
            _menuItems[_numberOfItems] = newItem;
            _numberOfItems++;
        }

        public IEnumerator<IMenuItem> CreateIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }
    }
}
