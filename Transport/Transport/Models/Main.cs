
using Transport.Repository;

namespace Transport.Models
{
    public class Main : IСommunication
    {
        public void Start()
        {
            IRepository car = new RepositoryCar();
            IRepository airPlane = new RepositoryAirplane();
            Console.WriteLine("Auto-fill with objects (Y/N)");
            string choise = Console.ReadLine().ToLower();
            if (choise == "y")
            {
                car.AutoFill();
                airPlane.AutoFill();
            }
                
            while (true)
            {
                int result = Menu();
                if (result == 1)
                {
                    while (true)
                    {
                        //=======================================
                        int transportType = TransportType();
                        //=======================================
                        int amount = new DataVerification().CorrectDataInt("Amount: ");
                        if (transportType == 1)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                Console.Write("\nModel: ");
                                string? model = Console.ReadLine();
                                Console.Write("Brand: ");
                                string? brand = Console.ReadLine();
                                float FuelConsumption = new DataVerification().CorrectDataFLoat("Fuel Consumption: ");
                                decimal Price = new DataVerification().CorrectDataDecimal("Price: ");
                                car.AddList(model, brand, FuelConsumption, Price);
                            }
                        }
                        else if (transportType == 2)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                Console.Write("\nModel: ");
                                string? model = Console.ReadLine();
                                Console.Write("Brand: ");
                                string? brand = Console.ReadLine();
                                float FuelConsumption = new DataVerification().CorrectDataFLoat("Fuel Consumption: ");
                                decimal Price = new DataVerification().CorrectDataDecimal("Price: ");
                                airPlane.AddList(model, brand, FuelConsumption, Price);
                            }
                        }
                        

                    }
                }
                else if (result == 2)
                {
                    car.ShowAll();
                    Console.WriteLine("");
                    airPlane.ShowAll();
                }
                else if (result == 3)
                {
                    int type = TransportType();
                    if (type == 1)
                        car.FindObject();
                    else
                        airPlane.FindObject();
                }
                else if (result == 4)
                {
                    int type = TransportType();
                    if (type == 1)
                        car.DeliteObject();
                    else
                        airPlane.DeliteObject();
                }
                else if (result == 5)
                {
                    int type = TransportType();
                    if (type == 1)
                        car.DemonstrationBehavior();
                    else
                        airPlane.DemonstrationBehavior();
                }
                else if (result == 0)
                {
                    return;
                }
            }
        }
        public int Menu()
        {
            Console.WriteLine("1. Add objects");
            Console.WriteLine("2. Show all");
            Console.WriteLine("3. Find objects");
            Console.WriteLine("4. Delite object");
            Console.WriteLine("5. Demonstration of the behavior of objects");
            Console.WriteLine("0. End program");
            Console.WriteLine("=========================");

            return new DataVerification().CorrectDataInt("Point: ");
        }
        public int TransportType()
        {
            Console.WriteLine("What type of transport ?");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Airplane");
            return new DataVerification().CorrectDataInt("Point: ");
        }
    }
}
