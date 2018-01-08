namespace MenuTestDrive.MenuItems
{
    class SteamedVeggiesAndBrownRice : IMenuItem
    {
        public string GetName()
        {
            return "Steamed Veggies and Brown Rice";
        }

        public double GetPrice()
        {
            return 3.99;
        }

        public string GetDescription()
        {
            return "Steamed Veggies over brown rice";
        }

        public bool IsVegitarian()
        {
            return true;
        }
    }
}
