namespace Transport.Models.Objects
{
    internal class TransportList
    {
        public List<Airplane> Airplane{ get; set; } = new List<Airplane>();
        public List<Car> Car{ get; set; } = new List<Car>();
    }
}
