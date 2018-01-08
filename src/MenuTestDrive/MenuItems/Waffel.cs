namespace MenuTestDrive.MenuItems
{
    class Waffel : IMenuItem
    {
        public string GetName()
        {
            return "Waffels";
        }

        public double GetPrice()
        {
            return 3.59;
        }

        public string GetDescription()
        {
            return "Waffels, with your choice of blueberries or strawberries";
        }

        public bool IsVegitarian()
        {
            return true;
        }
    }
}
