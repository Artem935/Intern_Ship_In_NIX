
namespace Transport
{
    public interface IСommunication
    {
        public void Start()
        {
            Console.WriteLine("Start");
        }
        public int TransportType()
        {
            return 0;
        }
    }
}
