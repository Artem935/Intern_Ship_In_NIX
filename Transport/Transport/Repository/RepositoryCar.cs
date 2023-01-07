using System.Reflection.PortableExecutable;
using Transport.Models;
using Transport.Models.Objects;

namespace Transport.Repository
{
    internal class RepositoryCar:IRepository<Car>
    {

        TransportList transport = new TransportList();

        //transport.Car - Робить список автомобілів
        //transport.Airplane- Робить список літаків

        public void AddList(Car properties)
        {
            int Id = transport.Car.Count;
            transport.Car.Add(new Car(Id, properties.Model, properties.Brand,properties.FuelConsumption, properties.Price));
            new DataVerification().Complete($"You add {Id}th object");
        }
        public void DeliteObject()
        {
            DataVerification сorrectData = new DataVerification();
            int choice = сorrectData.CorrectDataInt("Delite by :\n1. Id\n2. Brand\n");
            if (choice == 1)
            {
                int number = ReturnId();
                сorrectData.Complete("Was delite");
                transport.Car.RemoveAt(number);
                OverwriteId();
            }
            else if (choice == 2)
            {

                Console.Write("Enter brand name: ");
                string? brand = Console.ReadLine();
                Console.WriteLine("Object: ");
                bool c = true;
                for (int i = 0; i < transport.Car.Count(); i++)
                {
                    if (transport.Car[i].Brand == brand)
                    {
                        Console.WriteLine($"\t{transport.Car[i].Id}\t{transport.Car[i].Model}\t{transport.Car[i].Brand}" +
                                            $"\t{transport.Car[i].FuelConsumption}\t\t\t{transport.Car[i].Price}$\n");
                        transport.Car.RemoveAt(i);
                        i--;
                        c = false;
                    }
                    else if (c)
                    {
                        сorrectData.Erore("There is no such objects");
                    }
                }
                сorrectData.Complete("Was delite");
                OverwriteId();
            }

        }

        public int FindObject()
        {
            DataVerification сorrectData = new DataVerification();
            int choice = сorrectData.CorrectDataInt("Find by :\n1. Id\n2. Brand\n");
            if (choice == 1)
            {
                ReturnId();
            }
            else if (choice == 2)
            {
                Console.Write("Enter brand name: ");
                string? brand = Console.ReadLine();
                Console.WriteLine("\n\tId\tModel\tBrand\tFuel Consumption\tPrice");
                for (int i = 0; i < transport.Car.Count(); i++)
                {
                    if (transport.Car[i].Brand == brand)
                    {
                        Console.WriteLine($"\t{transport.Car[i].Id}\t{transport.Car[i].Model}\t{transport.Car[i].Brand}" +
                                        $"\t{transport.Car[i].FuelConsumption}\t\t\t{transport.Car[i].Price}$\n");
                    }
                    else if (i == transport.Car.Count() - 1)
                    {
                        сorrectData.Erore("There is no such object");
                    }

                }
            }
            return -1;
        }

        public int ReturnId()
        {
            while (true)
            {
                int number = new DataVerification().CorrectDataInt("Enter id: ");
                if (number >= transport.Car.Count())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("No such number\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.WriteLine("\tId\tModel\tBrand\tFuel Consumption\tPrice");
                    Console.WriteLine($"\t{transport.Car[number].Id}\t{transport.Car[number].Model}\t{transport.Car[number].Brand}" +
                                      $"\t{transport.Car[number].FuelConsumption}\t\t\t{transport.Car[number].Price}$\n");
                    return number;
                }
            }
        }


        public void ShowAll()
        {
            Console.WriteLine("\tId\tModel\t\tBrand\tFuel Consumption\tPrice");
            foreach (TransportAbstraction Car in transport.Car)
            {
                Console.WriteLine($"\t{Car.Id}\t{Car.Model}\t\t{Car.Brand}\t" +
                                   $"{Car.FuelConsumption}\t\t\t{Car.Price}$\t");
            }
        }
        public void AutoFill()
        {
            AddList(new Car(1,"ewe","wewe",12,12000));
            AddList(new Car(1,"A3", "Audi", 5.3f, 7000));
            AddList(new Car(1,"A6", "Audi", 4.5f, 10000));
            AddList(new Car(1, "M2", "BMW", 6f, 10000));
            AddList(new Car(1, "M8", "BMW", 6f, 20000));
            AddList(new Car(1, "X2", "BMW", 4f, 12500));
            AddList(new Car(1, "X7", "BMW", 9.8f, 25000));
        }
        private void OverwriteId()
        {
            for (int i = 0; i < transport.Car.Count(); i++)
                transport.Car[i].Id = i;
        }
        public void DemonstrationBehavior()
        {
            for (int i = 0; i < transport.Car.Count(); i++)
                new Car(i, transport.Car[i].Model, transport.Car[i].Brand,
                    transport.Car[i].FuelConsumption, transport.Car[i].Price).DoSomething();
        }
    }
}
