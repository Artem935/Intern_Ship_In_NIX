using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Transport.OrderByCondition.CarSorting
{
    internal interface ICarSorting<T>
    {
        public List<T> SortDescendingPrice(List<T> transport);

    }
}
