namespace Transport.Models.Objects
{
    [Serializable]
    public abstract class TransportAbstraction
    {
        public int Id{ get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public virtual float FuelConsumption { get; set; } /*{ get { return FuelConsumption; } set { if (value > 1000) { FuelConsumption = value; } } }*/
        public decimal Price { get; set; }
    }
}
