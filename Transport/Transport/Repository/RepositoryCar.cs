
using System.Reflection.PortableExecutable;
using System.Xml;
using System.Xml.Serialization;
using Transport.Behavior;
using Transport.DisplayConsole;
using Transport.Models;
using Transport.Models.Objects;
using Transport.Serserrealization;

namespace Transport.Repository
{
    [Serializable]
    internal class RepositoryCar:IRepository<Car>
    {
        // зробити ліст карів
        TransportList transport = new TransportList();
        public void AddList(Car properties)
        {
            int Id = transport.Cars.Count;
            transport.Cars.Add(new Car(Id, properties.Model, properties.Brand,properties.FuelConsumption, properties.Price));
            new DataVerification().Complete($"You add {Id}th object");
        }
        public void DeliteObject(int choice)
        {            
            if (choice == 1)
            {
                Car obj = ReturnObjectById(new DataVerification().CorrectDataInt("Enter id: "));
                Console.WriteLine(new Car().PrinAllProperties());
                Console.WriteLine(obj);
                transport.Cars.RemoveAt(obj.Id);
                OverwriteId();
                new DataVerification().Complete("Was delite");
            }
            else if (choice == 2)
            {
                Console.Write("Enter brand name: ");
                string? brand = Console.ReadLine();
                Console.WriteLine("Object: ");
                var obj = transport.Cars.Where(b => b.Brand == brand);
                if (obj == null)
                {
                    new DataVerification().Erore("There is no such objects");
                }
                else
                {
                    Console.WriteLine(new Car().PrinAllProperties());
                    foreach (var item in obj.ToList())
                    {
                        Console.WriteLine(item);
                        transport.Cars.Remove(item);
                    }
                    new DataVerification().Complete("Was delite");
                }
                OverwriteId();
            }
        }
        public int FindObject(int choice)
        {
            if (choice == 1)
            {
                var resulr = ReturnObjectById(new DataVerification().CorrectDataInt("Enter id: "));
                if (resulr == null)
                    new DataVerification().Erore("No such number");
                else
                    Console.WriteLine(resulr);
            }
            else if (choice == 2)
            {
                Console.Write("Enter brand name: ");
                string? brand = Console.ReadLine();
                Console.WriteLine(new Airplane().PrintAllProperties());
                var res = transport.Cars.Where((a) => a.Brand == brand);
                foreach (var item in res)
                {
                    Console.WriteLine(item);
                }
            }
            return -1;
        }
        public Car ReturnObjectById(int id)
        {
            return transport.Cars.FirstOrDefault(a => a.Id == id);
        }
        public void ShowAll()
        {
            Console.WriteLine(new Car().PrinAllProperties());
            var res = transport.Cars;
            foreach (var item in res)
            {
                Console.WriteLine(item);
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
            for (int i = 0; i < transport.Cars.Count(); i++)
                transport.Cars[i].Id = i;
        }
        public void Serserrealization(string path)
        {
                Serserrealiz<TransportList> serserrealiz = new Serserrealiz<TransportList>();
                serserrealiz.SerserrealizationXML(path, new RepositoryCar().GetType().Name, transport);
        }
        public void Deserserrealization(string path)
        {
            Deserserrealiz<TransportList> deserserrealiz = new Deserserrealiz<TransportList>();
            transport = deserserrealiz.DeserserrealizationXML(path, transport);
        }
        public void DemonstrationBehavior()
        {
            new CarBehavior().DoSomething(1);
            new CarBehavior().Turn();
        }
    }
}
