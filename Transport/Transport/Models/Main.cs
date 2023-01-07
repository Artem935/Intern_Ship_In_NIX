
using System.Diagnostics;
using System.Reflection;
using Transport.Models.Objects;
using Transport.Repository;

namespace Transport.Models
{
    public delegate void MenuDelegate();
    public class Main
    {
        
        public void Start()
        {
            IRepository<Car> car = new RepositoryCar();
            IRepository<Airplane> airPlane = new RepositoryAirplane();
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
                        int transportType = TransportType();
                        int amount = new DataVerification().CorrectDataInt("Amount: ");
                        if (transportType == 1)
                        {
                            for (int i = 0; i < amount; i++)
                                car.AddList(new Car(AddCar()));
                        }
                        else if (transportType == 2)
                        {
                            for (int i = 0; i < amount; i++)
                                airPlane.AddList(new Airplane(Airplane()));
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
                    else if (type == 2)
                        airPlane.FindObject();
                }
                else if (result == 4)
                {
                    int type = TransportType();
                    if (type == 1)
                        car.DeliteObject();
                    else if (type == 2)
                        airPlane.DeliteObject();
                }
                else if (result == 5)
                {
                    int type = TransportType();
                    if (type == 1)
                        car.DemonstrationBehavior();
                    else if (type == 2)
                        airPlane.DemonstrationBehavior();
                }
                else if (result == 0)
                {
                    return;
                }
            }
        }
        private (int id,string model, string brand, float FuelConsumption,decimal Price) AddCar()
        {
            Console.Write("\nModel: ");
            string? model = Console.ReadLine();
            Console.Write("Brand: ");
            string? brand = Console.ReadLine();
            float fuelConsumption = new DataVerification().CorrectDataFLoat("Fuel Consumption: ");
            decimal price = new DataVerification().CorrectDataDecimal("Price: ");
            return (0, model, brand, fuelConsumption, price);
        }
        private (int id, string model, string brand, float FuelConsumption, decimal Price) Airplane()
        {
            Console.Write("\nModel: ");
            string? model = Console.ReadLine();
            Console.Write("Brand: ");
            string? brand = Console.ReadLine();
            float fuelConsumption = new DataVerification().CorrectDataFLoat("Fuel Consumption: ");
            decimal price = new DataVerification().CorrectDataDecimal("Price: ");
            return (0, model, brand, fuelConsumption, price);
        }
        private int Menu()
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
        private int TransportType()
        {
            Console.WriteLine("What type of transport ?");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Airplane");
            return new DataVerification().CorrectDataInt("Point: ");
        }
    }
}
