using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Behavior
{
    internal class AirplaneBehavior: IBehavior
    {
        public void DoSomething(int id)
        {
            Console.WriteLine($"Airplane whith {id} do Fly");
        }
        public void Turn()
        {
            Console.WriteLine($"Turn Left");
        }
    }
}
