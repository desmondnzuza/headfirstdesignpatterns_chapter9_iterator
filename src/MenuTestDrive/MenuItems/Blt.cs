namespace MenuTestDrive.MenuItems
{
    class Blt : IMenuItem
    {
        public string GetName()
        {
            return "BLT";
        }

        public double GetPrice()
        {
            return 2.99;
        }

        public string GetDescription()
        {
            return "Bacon with lettuce & tomatoe on whole wheat";
        }

        public bool IsVegitarian()
        {
            return false;
        }
    }
}
