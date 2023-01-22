using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Behavior
{
    internal class CarBehavior:IBehavior
    {
        public void DoSomething(int id)
        {
            Console.WriteLine($"Car whith {id} do Wruuuum");
        }
        public void Turn()
        {
            Console.WriteLine($"Turn Left");
        }
    }
}
