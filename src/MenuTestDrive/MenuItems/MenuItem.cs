namespace MenuTestDrive.MenuItems
{
    class MenuItem : IMenuItem
    {
        private readonly string _name;
        private readonly double _price;
        private readonly string _description;
        private readonly bool _isVegitarian;

        public MenuItem(string name, string description, bool vegitarian, double price)
        {
            _name = name;
            _price = price;
            _description = description;
            _isVegitarian = vegitarian;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetPrice()
        {
            return _price;
        }

        public string GetDescription()
        {
            return _description;
        }

        public bool IsVegitarian()
        {
            return _isVegitarian;
        }
    }
}
