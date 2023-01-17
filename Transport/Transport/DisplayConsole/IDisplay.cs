using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Transport.DisplayConsole
{
    internal interface IDisplay
    {
        public void Start() { }
        public (int id, string model, string brand, float FuelConsumption, decimal Price) AddCar() 
        {
            return (0, "model","brand", 12.3f, 10000); 
        }
        private (int id, string model, string brand, float FuelConsumption, decimal Price) Airplane()
        {
            return (0, "model", "brand", 12.3f, 10000);
        }
        public int Menu() { return 0; }
        private int TransportType() { return 0; }
        
    }
}
