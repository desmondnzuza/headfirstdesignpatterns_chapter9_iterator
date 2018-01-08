namespace MenuTestDrive.MenuItems
{
    class SoupOfTheDay : IMenuItem
    {
        public string GetName()
        {
            return "Soup of the day";
        }

        public double GetPrice()
        {
            return 3.29;
        }

        public string GetDescription()
        {
            return "Soup of the day, with a side of potato salad";
        }

        public bool IsVegitarian()
        {
            return false;
        }
    }
}
