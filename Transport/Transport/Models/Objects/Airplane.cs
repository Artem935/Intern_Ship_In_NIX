﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Transport.Models.Objects
{
    
    [Serializable]
    public class Airplane : TransportAbstraction
    {
        public Airplane() { }
        public Airplane((int id, string model, string brand, float fuelConsumption, decimal price) value)
        {
            Id = value.id;
            Model = value.model;
            Brand = value.brand;
            FuelConsumption = value.fuelConsumption;
            Price = value.price;
        }

        public Airplane(int id, string model, string brand, float fuelConsumption, decimal price)
        {
            Id = id;
            Model = model;
            Brand = brand;
            FuelConsumption = fuelConsumption;
            Price = price;
        }

        public string PrintHeader()
        {
                return "\tId\tModel\t\tBrand\tFuel Consumption\tPrice";
        }
        // как оно вообще работает !!!!!!!!!!!!!!!!!!!!!!!!!!
        public override string ToString()
        {
            return $"\t{Id}\t{Model}\t\t{Brand}\t{FuelConsumption}\t\t\t{Price}$";
        }

    }
}
