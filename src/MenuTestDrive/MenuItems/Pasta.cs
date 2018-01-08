namespace MenuTestDrive.MenuItems
{
    class Pasta : IMenuItem
    {
        public string GetName()
        {
            return "Pasta";
        }

        public double GetPrice()
        {
            return 3.89;
        }

        public string GetDescription()
        {
            return "Spaghetti with Marina Source, and a slice of sourdough bread";
        }

        public bool IsVegitarian()
        {
            throw new System.NotImplementedException();
        }
    }
}
