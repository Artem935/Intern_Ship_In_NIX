﻿using System;
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


    }
}
