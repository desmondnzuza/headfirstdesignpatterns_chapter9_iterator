namespace MenuTestDrive.MenuItems
{
    class KbPancakeBreakfast : IMenuItem
    {
        public string GetName()
        {
            return "K&B's Pancake Breakfast";
        }

        public double GetPrice()
        {
            return 2.99;
        }

        public string GetDescription()
        {
            return "Pancakes with scrambled eggs, and toast";
        }

        public bool IsVegitarian()
        {
            return false;
        }
    }
}
