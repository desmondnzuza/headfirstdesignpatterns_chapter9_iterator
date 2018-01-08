using System;
using MenuTestDrive.MenuItems;
using MenuTestDrive.Menus;

namespace MenuTestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();
            
            var waitress = new Waitress(pancakeHouseMenu, dinerMenu);

            waitress.PrintMenu();

            Console.ReadLine();
        }
    }
}
