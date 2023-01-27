namespace Transport.Models.Objects
{
    [Serializable]
    public class TransportList
    {
        public List<Airplane> Airplanes{ get; set; } = new List<Airplane>();
        public List<Car> Cars{ get; set; } = new List<Car>();
    }
}
