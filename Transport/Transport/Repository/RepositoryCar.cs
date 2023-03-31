
using System.Reflection.PortableExecutable;
using System.Xml;
using System.Xml.Serialization;
using Transport.Behavior;
using Transport.DisplayConsole;
using Transport.Models;
using Transport.Models.Objects;
using Transport.OrderByCondition;
using Transport.OrderByCondition.CarSorting;
using Transport.Serserrealization;
using Transport.SortByCondition;
using Transport.TransfonrmOnFile;

namespace Transport.Repository
{
    [Serializable]
    internal class RepositoryCar:IRepository<Car>
    {
        List<Car> transport = new List<Car>();
        public void AddList(Car properties)
        {
            int Id = transport.Count;
            transport.Add(new Car(Id, properties.Model, properties.Brand,properties.FuelConsumption, properties.Price));
            new DataVerification().Complete($"You add {Id}th object");
        }
        public void DeliteObject(int choice)
        {            
            if (choice == 1)
            {
                Car obj = ReturnObjectById(new DataVerification().CorrectDataInt("Enter id: "));
                Console.WriteLine(new Car().PrinAllProperties());
                Console.WriteLine(obj);
                transport.RemoveAt(obj.Id);
                OverwriteId();
                new DataVerification().Complete("Was delite");
            }
            else if (choice == 2)
            {
                Console.Write("Enter brand name: ");
                string? brand = Console.ReadLine();
                Console.WriteLine("Object: ");
                var obj = transport.Where(b => b.Brand == brand);
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
                        transport.Remove(item);
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
                var res = transport.Where((a) => a.Brand == brand);
                foreach (var item in res)
                {
                    Console.WriteLine(item);
                }
            }
            return -1;
        }
        public Car ReturnObjectById(int id)
        {
            return transport.FirstOrDefault(a => a.Id == id);
        }
        public void ShowAll()
        {
            Console.WriteLine(new Car().PrinAllProperties());
            transport = new AbstractionSorting<Car>().SortDescendingPrice(transport);
            var res = transport;
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
        private void OverwriteId()
        {
            for (int i = 0; i < transport.Count(); i++)
                transport[i].Id = i;
        }
        public void DemonstrationBehavior()
        {
            new CarBehavior().DoSomething(1);
            new CarBehavior().Turn();
        }
        public void Save(string path, int type)
        {
            new TransformOnFile<Car>().Save(path, transport, type);
        }
        public void Load(string path)
        {
            transport = new Deserrealiz<Car>().DeserrealizationXML(path);
        }
        public void AutoFill()
        {
            AddList(new Car(1, "ewe", "wewe", 12, 12000));
            AddList(new Car(1, "A3", "Audi", 5.3f, 7000));
            AddList(new Car(1, "A6", "Audi", 4.5f, 10000));
            AddList(new Car(1, "M2", "BMW", 6f, 10000));
            AddList(new Car(1, "M8", "BMW", 6f, 20000));
            AddList(new Car(1, "X2", "BMW", 4f, 12500));
            AddList(new Car(1, "X7", "BMW", 9.8f, 25000));
        }
    }
}
