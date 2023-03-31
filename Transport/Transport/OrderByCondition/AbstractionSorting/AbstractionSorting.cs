using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.Models.Objects;

namespace Transport.OrderByCondition.CarSorting
{
    public class AbstractionSorting<T> : IAbstractionSorting<T> where T : TransportAbstraction
    {
        public List<T> SortAscendingPrice(List<T> transport)
        {
            return transport.OrderBy(p => p.Price).ToList();
        }
        public List<T> SortDescendingPrice(List<T> transport)
        {
            return transport.OrderByDescending(p => p.Price).ToList();
        }

    }
}
