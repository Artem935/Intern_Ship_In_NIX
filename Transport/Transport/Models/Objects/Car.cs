using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Models.Objects
{
    public class Car : TransportAbstraction
    {
        public Car() { }

        public Car((int id, string model, string brand, float fuelConsumption, decimal price) value)
        {
            Id = value.id;
            Model = value.model;
            Brand = value.brand;
            FuelConsumption = value.fuelConsumption;
            Price = value.price;
        }
        public Car(int id, string model, string brand, float fuelConsumption, decimal price)
        {
            Id = id;
            Model = model;
            Brand = brand;
            FuelConsumption = fuelConsumption;
            Price = price;
        }
        public bool Discount
        {
            get { return true; }
            private set { if (Price >= 10000) Discount = true; }
        }
        public override void DoSomething()
        {
            Console.WriteLine($" Car with Id {Id} do: Wruuum");
        }
    }
}
