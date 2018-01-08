namespace MenuTestDrive.MenuItems
{
    class BlueberryPancake : IMenuItem
    {
        public string GetName()
        {
            return "Blueberry Pancake";
        }

        public double GetPrice()
        {
            return 3.49;
        }

        public string GetDescription()
        {
            return "Pancakes made with fresh blueberries";
        }

        public bool IsVegitarian()
        {
            return false;
        }
    }
}
