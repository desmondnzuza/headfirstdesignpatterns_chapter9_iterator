using System;
using System.Collections.Generic;
using MenuTestDrive.Iterators;
using MenuTestDrive.MenuItems;
using MenuTestDrive.Menus;

namespace MenuTestDrive
{
    class Waitress
    {
        private readonly PancakeHouseMenu _pancakeHouseMenu;
        private readonly DinerMenu _dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            IEnumerator<IMenuItem> pancakeIterator = _pancakeHouseMenu.CreateIterator();
            IEnumerator<IMenuItem> dinerIterator = _dinerMenu.CreateIterator();

            Console.WriteLine("MENU====\nBREAKFAST");
            PrintMenu(pancakeIterator);

            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(IEnumerator<IMenuItem> iterator)
        {
            while (iterator.MoveNext())
            {
                IMenuItem menuItem = iterator.Current;
                Console.Write($"{menuItem.GetName()}, ");
                Console.Write($"R{menuItem.GetPrice()} --");
                Console.WriteLine(menuItem.GetDescription());
            }
        }
    }
}
