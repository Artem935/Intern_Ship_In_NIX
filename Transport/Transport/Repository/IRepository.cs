using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Repository
{
    internal interface IRepository
    {
        public void AddList(string Model, string Brand, float FuelConsumption, decimal Price);
        public void DeliteObject();
        public int FindObject();
        public int ReturnId();
        public void ShowAll();
        public void AutoFill();
        public void DemonstrationBehavior();


    }
}
