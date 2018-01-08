namespace MenuTestDrive.MenuItems
{
    class Hotdog : IMenuItem
    {
        public string GetName()
        {
            return "Hotdog";
        }

        public double GetPrice()
        {
            return 3.05;
        }

        public string GetDescription()
        {
            return "A hot dog, with saurkraut, relish, onions topped with cheese";
        }

        public bool IsVegitarian()
        {
            return false;
        }
    }
}
