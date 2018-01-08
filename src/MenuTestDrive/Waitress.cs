using System;
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
            IIterator pancakeIterator = _pancakeHouseMenu.CreateIterator(); //TODO: add implementation here
            IIterator dinerIterator = _dinerMenu.CreateIterator();   //TODO: add implementation here

            Console.WriteLine("MENU====\nBREAKFAST");
            PrintMenu(pancakeIterator);

            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                IMenuItem menuItem = (IMenuItem) iterator.Next();
                Console.Write($"{menuItem.GetName()}, ");
                Console.Write($"R{menuItem.GetPrice()} --");
                Console.WriteLine(menuItem.GetDescription());
            }
        }
    }
}
