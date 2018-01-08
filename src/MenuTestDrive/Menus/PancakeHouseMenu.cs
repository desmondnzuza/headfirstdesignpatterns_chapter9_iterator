using System.Collections.Generic;
using MenuTestDrive.Iterators;
using MenuTestDrive.MenuItems;

namespace MenuTestDrive.Menus
{
    class PancakeHouseMenu
    {
        private readonly List<IMenuItem> _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new List<IMenuItem>();

            AddItem(new KbPancakeBreakfast());
            AddItem(new RegularPancakeBreakfast());
            AddItem(new BlueberryPancake());
            AddItem(new Waffel());
        }

        public void AddItem(string name, string description, bool vegitarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegitarian, price);
            _menuItems.Add(menuItem);
        }

        public void AddItem(IMenuItem menuItem)
        {
            _menuItems.Add(menuItem);
        }

        public IIterator CreateIterator()
        {
            return new PancakeMenuIterator(_menuItems);
        }
    }
}
