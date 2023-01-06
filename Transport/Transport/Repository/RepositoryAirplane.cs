using Transport.Models.Objects;
using Transport.Models;

namespace Transport.Repository
{
    internal class RepositoryAirplane: IRepository<Airplane>
    {
        TransportList transport = new TransportList();

        public void AddList(Airplane properties)
        {
            int Id = transport.Airplane.Count;
            transport.Airplane.Add(new Airplane(Id, properties.Model, properties.Brand, properties.FuelConsumption, properties.Price));
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
                transport.Airplane.RemoveAt(number);
                OverwriteId();
            }
            else if (choice == 2)
            {

                Console.Write("Enter brand name: ");
                string? brand = Console.ReadLine();
                Console.WriteLine("Object: ");
                bool c = true;
                for (int i = 0; i < transport.Airplane.Count(); i++)
                {
                    if (transport.Airplane[i].Brand == brand)
                    {
                        Console.WriteLine($"\t{transport.Airplane[i].Id}\t{transport.Airplane[i].Model}\t{transport.Airplane[i].Brand}" +
                                            $"\t{transport.Airplane[i].FuelConsumption}\t\t\t{transport.Airplane[i].Price}$\n");
                        transport.Airplane.RemoveAt(i);
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
                for (int i = 0; i < transport.Airplane.Count(); i++)
                {
                    if (transport.Airplane[i].Brand == brand)
                    {
                        Console.WriteLine($"\t{transport.Airplane[i].Id}\t{transport.Airplane[i].Model}\t{transport.Airplane[i].Brand}" +
                                        $"\t{transport.Airplane[i].FuelConsumption}\t\t\t{transport.Airplane[i].Price}$\n");
                    }
                    else if (i == transport.Airplane.Count() - 1)
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
                if (number >= transport.Airplane.Count())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("No such number\n");
                    Console.ForegroundColor = ConsoleColor.Gray;

                }
                else
                {
                    Console.WriteLine("\tId\tModel\tBrand\tFuel Consumption\tPrice");
                    Console.WriteLine($"\t{transport.Airplane[number].Id}\t{transport.Airplane[number].Model}\t{transport.Airplane[number].Brand}" +
                                      $"\t{transport.Airplane[number].FuelConsumption}\t\t\t{transport.Airplane[number].Price}$\n");
                    return number;
                }
            }
        }


        public void ShowAll()
        {
            Console.WriteLine("\tId\tModel\t\tBrand\tFuel Consumption\tPrice");
            foreach (TransportAbstraction Airplane in transport.Airplane)
            {
                Console.WriteLine($"\t{Airplane.Id}\t{Airplane.Model}\t\t{Airplane.Brand}\t" +
                                   $"{Airplane.FuelConsumption}\t\t\t{Airplane.Price}$\t");
            }
        }
        public void AutoFill()
        {
            AddList(new Airplane(1,"707", "Boing", 4.3f, 10000000));
            AddList(new Airplane(1,"717", "Boing", 6.5f, 15000000));
            AddList(new Airplane(1, "727", "Boing", 5.3f, 70000000));
            AddList(new Airplane(1, "737", "Boing", 4.5f, 10000000));
            AddList(new Airplane(1, "747", "Boing", 6f, 18900000));
            AddList(new Airplane(1, "757", "Boing", 6f, 23400000));
            AddList(new Airplane(1, "767", "Boing", 4f, 12500000));
            AddList(new Airplane(1, "777", "Boing", 9.8f, 25000000));
        }
        void OverwriteId()
        {
            for (int i = 0; i < transport.Airplane.Count(); i++)
                transport.Airplane[i].Id = i;
        }
        public void DemonstrationBehavior()
        {
            for (int i = 0; i < transport.Airplane.Count(); i++)
                new Airplane(i, transport.Airplane[i].Model, transport.Airplane[i].Brand,
                    transport.Airplane[i].FuelConsumption, transport.Airplane[i].Price).DoSomething();
        }

    }
}

