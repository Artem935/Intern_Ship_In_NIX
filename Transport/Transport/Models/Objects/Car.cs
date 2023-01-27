using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Models.Objects
{
    [Serializable]
    public class Car : TransportAbstraction
    {
        public Car() { }
        public Car(int id, string model, string brand, float fuelConsumption, decimal price)
        {
            Id = id;
            Model = model;
            Brand = brand;
            FuelConsumption = fuelConsumption;
            Price = price;
        }
        public string PrinAllProperties()
        {
            return "\tId\tModel\t\tBrand\tFuel Consumption\tPrice";
        }
        public string PrintAvailableProperties()
        {
            return "\n1. Id\n2. Brand\n";
        }
        public override string ToString()
        {
            return $"\t{Id}\t{Model}\t\t{Brand}\t{FuelConsumption}\t\t\t{Price}$";
        }

    }
}
