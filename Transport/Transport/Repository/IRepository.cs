using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Repository
{
    internal interface IRepository<T> where T : class
    {
        public void AddList(T properties);
        public void DeliteObject();
        public int FindObject();
        public int ReturnId();
        public void ShowAll();
        public void AutoFill();
        public void DemonstrationBehavior();


    }
}
