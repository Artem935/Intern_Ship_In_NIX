using Transport.Models.Objects;
using Transport.Behavior;
using Transport.Serserrealization;
using Transport.DisplayConsole;
using Transport.TransfonrmOnFile;

namespace Transport.Repository
{
    [Serializable]
    internal class RepositoryAirplane: IRepository<Airplane>
    {
        List<Airplane> transport = new List<Airplane>();
        public void AddList(Airplane properties)
        {
            int Id = transport.Count;
            transport .Add(new Airplane(Id, properties.Model, properties.Brand, properties.FuelConsumption, properties.Price));
            new DataVerification().Complete($"You add {Id}th object");
        }
        public void DeliteObject(int choice)
        {
            DataVerification сorrectData = new DataVerification();
            if (choice == 1)
            {
                Airplane obj = ReturnObjectById(new DataVerification().CorrectDataInt("Enter id: "));
                transport .RemoveAt(obj.Id);
                Console.WriteLine(new Airplane().PrintAllProperties());
                Console.WriteLine(obj);
                OverwriteId();
                сorrectData.Complete("Was delite");
            }
            else if (choice == 2)
            {
                Console.Write("Enter brand name: ");
                string? brand = Console.ReadLine();
                var obj = transport .Where(b => b.Brand == brand);
                if (obj == null)
                {
                    сorrectData.Erore("There is no such objects");
                }
                else
                {
                    Console.WriteLine(new Airplane().PrintAllProperties());
                    foreach (var item in obj.ToList())
                    {
                        Console.WriteLine(item);
                        transport .Remove(item);
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
                if (resulr == null )
                    new DataVerification().Erore("No such number");
                else
                    Console.WriteLine(resulr);
            }
            else if (choice == 2)
            {
                Console.Write("Enter brand name: ");
                string? brand = Console.ReadLine();
                Console.WriteLine(new Airplane().PrintAllProperties());
                var res = transport .Where((a) => a.Brand == brand);
                foreach (var item in res)
                {
                    Console.WriteLine(item);
                }
            }
            return -1;
        }
        // ???????????????????????????????????
        public Airplane ReturnObjectById(int id)
        {
            return transport .FirstOrDefault(a => a.Id == id);
        }
        public void ShowAll()
        {
            Console.WriteLine(new Airplane().PrintAllProperties());
            var res = transport ;
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
        public void AutoFill()
        {
            AddList(new Airplane(1, "707", "Boing", 4.3f, 10000000));
            AddList(new Airplane(1, "717", "Boing", 6.5f, 15000000));
            AddList(new Airplane(1, "727", "Boing", 5.3f, 70000000));
            AddList(new Airplane(1, "737", "Boing", 4.5f, 10000000));
            AddList(new Airplane(1, "747", "Boing", 6f, 18900000));
            AddList(new Airplane(1, "757", "Boing", 6f, 23400000));
            AddList(new Airplane(1, "767", "Boing", 4f, 12500000));
            AddList(new Airplane(1, "777", "Boing", 9.8f, 25000000));
        }
        public void OverwriteId()
        {
            for (int i = 0; i < transport .Count(); i++) { transport [i].Id = i; }
        }
        public void DemonstrationBehavior()
        {
            new AirplaneBehavior().DoSomething(1);
            new AirplaneBehavior().Turn();
        }
        public void Save(string path, int type)
        {
            new TransformOnFile<Airplane>().Save(path,transport, type);
        }
        public void Load(string path)
        {
            transport = new Deserrealiz<Airplane>().DeserrealizationXML(path);
        }
    }
}

