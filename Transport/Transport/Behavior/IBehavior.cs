using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Behavior
{
    internal interface IBehavior
    {
        public void DoSomething(int id){ }
        public void Turn(){  }
    }
}
