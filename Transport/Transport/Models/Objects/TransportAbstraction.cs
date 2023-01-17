namespace Transport.Models.Objects
{
    [Serializable]
    public abstract class TransportAbstraction
    {
        public int Id
        {
            get { return id; }
            set { if (value >= 0) id = value; }
        }
        public string Model { get { return model; }  set { if (!string.IsNullOrEmpty(value)) model = value; } }
        public string Brand { get { return brand; }  set { if (!string.IsNullOrEmpty(value)) brand = value; } }
        public float FuelConsumption { get { return fuelConsumption; }  set { if (value > 0) fuelConsumption = value; } }
        public decimal Price { get { return price; }  set { if (value > 0) price = value; } }

        private int id = 0;
        private string model = "{Model}";
        private string brand = "{Brand}";
        private float fuelConsumption = 0;
        private decimal price = 0;
    }
}
