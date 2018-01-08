namespace MenuTestDrive.MenuItems
{
    class RegularPancakeBreakfast : IMenuItem
    {
        public string GetName()
        {
            return "Regular Pancake Breakfast";
        }

        public double GetPrice()
        {
            return 2.99;
        }

        public string GetDescription()
        {
            return "Pancakes with fried eggs, source";
        }

        public bool IsVegitarian()
        {
            return false;
        }
    }
}
