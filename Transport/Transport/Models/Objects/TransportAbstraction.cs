namespace Transport.Models.Objects
{
    public abstract class TransportAbstraction
    {
        public int Id
        {
            get { return id; }
            set { if (value >= 0) id = value; }
        }
        public string Model { get { return model; } protected set { if (!string.IsNullOrEmpty(value)) model = value; } }
        public string Brand { get { return brand; } protected set { if (!string.IsNullOrEmpty(value)) brand = value; } }
        public float FuelConsumption { get { return fuelConsumption; } protected set { if (value > 0) fuelConsumption = value; } }
        public decimal Price { get { return price; } protected set { if (value > 0) price = value; } }

        private int id = 0;
        private string model = "{Model}";
        private string brand = "{Brand}";
        private float fuelConsumption = 0;
        private decimal price = 0;
        public virtual void DoSomething()
        {
            Console.WriteLine($" Car with Id {id} do: Beeb");
        }
    }
}
