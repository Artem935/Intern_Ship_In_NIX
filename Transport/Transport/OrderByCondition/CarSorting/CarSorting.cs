using System;
using Transport.Models.Objects;
using Transport.OrderByCondition.CarSorting;

namespace Transport.SortByCondition
{
    internal class CarSorting :ICarSorting<Car> 
    { 
        public List<Car> SortDescendingPrice(List<Car> transport)
        {
            transport.OrderByDescending(p => p.Price);
            return transport;
        }
    }
}
