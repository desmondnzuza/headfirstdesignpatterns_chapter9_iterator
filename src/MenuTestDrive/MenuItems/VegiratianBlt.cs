namespace MenuTestDrive.MenuItems
{
    class VegiratianBlt : IMenuItem
    {
        public string GetName()
        {
            return "Vegitarian BLT";
        }

        public double GetPrice()
        {
            return 2.99;
        }

        public string GetDescription()
        {
            return "(Fakin') Bacon with lettuce & tomato on whole wheat";
        }

        public bool IsVegitarian()
        {
            return true;
        }
    }
}
