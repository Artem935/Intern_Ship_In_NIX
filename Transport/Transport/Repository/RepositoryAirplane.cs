using Transport.Models.Objects;
using Transport.Models;
using Transport.Behavior;
using System.Xml.Serialization;
using System;
using System.Xml;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Http.Headers;
using Transport.Serserrealization;

namespace Transport.Repository
{


    [Serializable]

    internal class RepositoryAirplane: IRepository<Airplane>
    {
        TransportList transport = new TransportList();
        public void AddList(Airplane properties)
        {
            int Id = transport.Airplane.Count;
            transport.Airplane.Add(new Airplane(Id, properties.Model, properties.Brand, properties.FuelConsumption, properties.Price));
            new DataVerification().Complete($"You add {Id}th object");
        }
        public void DeliteObject(int choice)
        {
            DataVerification сorrectData = new DataVerification();
            if (choice == 1)
            {
                Airplane obj = ReturnObjectById(new DataVerification().CorrectDataInt("Enter id: "));
                transport.Airplane.RemoveAt(obj.Id);
                Console.WriteLine(new Airplane().PrintAllProperties());
                Console.WriteLine(obj);
                OverwriteId();
                сorrectData.Complete("Was delite");
            }
            else if (choice == 2)
            {
                Console.Write("Enter brand name: ");
                string? brand = Console.ReadLine();
                var obj = transport.Airplane.Where(b => b.Brand == brand);
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
                        transport.Airplane.Remove(item);
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
                var res = transport.Airplane.Where((a) => a.Brand == brand);
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
            return transport.Airplane.FirstOrDefault(a => a.Id == id);
        }
        public void ShowAll()
        {
            Console.WriteLine(new Airplane().PrintAllProperties());
            var res = transport.Airplane;
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
            for (int i = 0; i < transport.Airplane.Count(); i++) { transport.Airplane[i].Id = i; }
        }
        public void Serserrealization(string path)
        {
            Serserrealiz<TransportList> serserrealiz = new Serserrealiz<TransportList>();
            serserrealiz.SerserrealizationXAML(path, new RepositoryAirplane().GetType().Name, transport);
        }
        public void Deserserrealization(string path)
        {
            Deserserrealiz<TransportList> deserserrealiz = new Deserserrealiz<TransportList>();
            transport = deserserrealiz.DeserserrealizationXAML(path, transport);
        }
        public void DemonstrationBehavior()
        {
                new AirplaneBehavior().DoSomething(1);
                new AirplaneBehavior().Turn();
        }
    }
}

